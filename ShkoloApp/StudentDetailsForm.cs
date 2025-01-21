using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShkoloApp
{
    public partial class StudentDetailsForm : Form
    {
        private readonly Student student;

        public StudentDetailsForm(Student student)
        {
            InitializeComponent();

            this.student = student;
        }

        private void FillStudentInfoLabels()
        {
            this.studentName.Text = "Name: " + this.student.Name;
            this.studentGrade.Text = "Grade: " + this.student.Grade.ToString();
            this.studentAverage.Text = "Average: " + this.student.AverageMark.ToString("f2");

            this.excusedLabel.Text = "Excused abscences: " + this.student.ExcusedAbscences.ToString();
            this.unexcusedLabel.Text = "Unexcused abscences: " + this.student.UnexcusedAbscences.ToString();
            this.labelTotal.Text = "Total abscences: " + this.student.TotalAbscences.ToString();
        }

        private void AddMarksToListView(string subject, List<double> grades)
        {
            ListViewItem col = new ListViewItem(subject);
            col.SubItems.Add(string.Join(", ", grades));
            this.listView1.Items.Add(col);
        }

        private void UpdateListViewWithGrades()
        {
            this.listView1.Items.Clear();

            AddMarksToListView("Mathematics", this.student.MathematicsGrades);
            AddMarksToListView("Informatics", this.student.InformaticsGrades);
            AddMarksToListView("Sport", this.student.SportGrades);
        }

        private void ChangeColor()
        {
            this.BackColor = Color.FromArgb(228, 131, 151);
            this.ForeColor = Color.White;

            this.labelTooManyAbscences.Visible = true;
            
            this.addAbscenceButton.BackColor = Color.FromArgb(237, 30, 54);
            this.addMarkButton.BackColor = Color.FromArgb(237, 30, 54);

            this.listView1.BackColor  = Color.FromArgb(228, 205, 211);

            this.typeComboBox.BackColor = Color.FromArgb(228, 205, 211);
            this.subjectComboBox.BackColor = Color.FromArgb(228, 205, 211);

            this.newMarkBox.BackColor = Color.FromArgb(228, 205, 211);
            this.abscenceCountBox.BackColor = Color.FromArgb(228, 205, 211);
            
        }

        private void CheckForWarnings()
        {
            if (this.student.UnexcusedAbscences > 10)
            {
                ChangeColor();
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            FillStudentInfoLabels();
            UpdateListViewWithGrades();
            CheckForWarnings();
        }

        private void GetNewMarkInfo(out double mark, out string subject)
        {
            mark = double.Parse(this.newMarkBox.Text);
            subject = this.subjectComboBox.Text;

            if (string.IsNullOrEmpty(subject) || mark < 2 || mark > 6) throw new Exception();
        }

        private void AddMark()
        {
            GetNewMarkInfo(out double grade, out string subject);

            Dictionary<string, List<double>> subjectGrades = new()
            {
                {
                    "Mathematics",
                    this.student.MathematicsGrades
                },
                {
                    "Informatics",
                    this.student.InformaticsGrades
                },
                {
                    "Sport",
                    this.student.SportGrades
                }
            };

            if (subjectGrades.ContainsKey(subject)) subjectGrades[subject].Add(grade);
        }

        private void ClearInputs()
        {
            this.newMarkBox.Clear();

            //this.subjectComboBox.ClearSelected();
            //this.typeComboBox.ClearSelected();

            this.abscenceCountBox.Value = 0;
        }

        private void ShowErrorMessage(Label label)
        {
            label.Visible = true;

            Task.Delay(3000).ContinueWith(_ =>
            {
                Invoke(new MethodInvoker(() => {
                    label.Visible = false;
                }));
            });
        }

        private void ButtonAddNewMarkClick(object sender, EventArgs e)
        {
            try
            {
                AddMark();
                FillStudentInfoLabels();
                UpdateListViewWithGrades();
                ClearInputs();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(this.errorNewMark);
            }
        }

        private void GetNewAbsenceInfo(out string selectedAbsenceType, out int numberOfAbsences)
        {
            selectedAbsenceType = this.typeComboBox.Text;
            numberOfAbsences = int.Parse(this.abscenceCountBox.Value.ToString());
        }

        private void AddAbsence()
        {
            GetNewAbsenceInfo(out string selectedAbscenceType, out int numberOfAbscences);

            Dictionary<string, Action<int>> abscenceActions = new()
            {
                {
                    "Excused",
                    absences => this.student.ExcusedAbscences += absences
                },
                {
                    "Unexcused",
                    abscences => this.student.UnexcusedAbscences += abscences
                }
            };

            if (!abscenceActions.ContainsKey(selectedAbscenceType) || numberOfAbscences < 0) throw new Exception();

            abscenceActions[selectedAbscenceType](numberOfAbscences);
        }

        private void ButtonAddNewAbscenceClick(object sender, EventArgs e)
        {
            try
            {
                AddAbsence();
                FillStudentInfoLabels();
                ClearInputs();
                CheckForWarnings();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(this.errorAbscenceLabel);
            }
        }
    }
}
