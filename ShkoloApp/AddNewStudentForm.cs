using System;
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
    public partial class AddNewStudentForm : Form
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public AddNewStudentForm()
        {
            InitializeComponent();
        }

        private bool IsNameEmpty()
        {
            return string.IsNullOrWhiteSpace(this.studentName.Text);
        }

        private bool IsGradesValid()
        {
            if (string.IsNullOrWhiteSpace(this.studentGrade.Text)) return false;

            if (double.TryParse(this.studentGrade.Text, out double gradeValue))
                return gradeValue >= 1 && gradeValue <= 12;

            return false;
        }

        private bool IsInputsValid()
        {
            return !IsNameEmpty() && IsGradesValid();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if (!IsInputsValid())
            {
                ValidateChildren(ValidationConstraints.Enabled);
                return;
            }

            this.Name = this.studentName.Text.Trim();
            this.Grade = int.Parse(this.studentGrade.Text.Trim());

            DialogResult = DialogResult.OK;
        }

        private void ValidateStudentsName(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.studentName.Text))
            {
                e.Cancel = true;
                this.errorProvider1.SetError(this.studentName, "Name should not be an empty string!");
                this.errorInvalidNameLabel.Visible = true;
            }
            else
            {
                e.Cancel = false;
                this.errorProvider1.SetError(this.studentName, string.Empty);
                this.errorInvalidNameLabel.Visible = false;
            }
        }

        private void ValidatingGrade(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.studentGrade.Text) ||
                !double.TryParse(this.studentGrade.Text, out double gradeValue) ||
                gradeValue < 1 || gradeValue > 12)
            {
                e.Cancel = true;
                this.errorProvider1.SetError(this.studentGrade, "Grade must be between 1 and 12!");
                this.errorInvalidGradeLabel.Visible = true;
            }
            else
            {
                e.Cancel = false;
                this.errorProvider1.SetError(this.studentGrade, string.Empty);
                this.errorInvalidGradeLabel.Visible = false;
            }
        }
    }
}
