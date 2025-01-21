namespace ShkoloApp
{
    public partial class Form1 : Form
    {
        private readonly List<Student> students = new()
        {
            new Student(
                "Mark Hil",
                12,
                new() { 6, 2, 3.54 },
                new() { 3.78, 5.8, 4.34 },
                new() { 5.50, 6, 5 }
            ),
            new Student(
                "John Tven",
                10,
                new() { 5.43, 2, 3.34 },
                new() { 3, 5.34, 4.43 },
                new() { 5.23, 6, 5.54 }
            )
        };

        private void LoadAllStudents()
        {
            this.studentGradesView.Items.Clear();

            foreach (Student student in students)
            {
                ListViewItem row = new(student.Name);

                row.SubItems.Add(string.Join(", ", student.MathematicsGrades));
                row.SubItems.Add(string.Join(", ", student.InformaticsGrades));
                row.SubItems.Add(string.Join(", ", student.SportGrades));

                this.studentGradesView.Items.Add(row);
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            LoadAllStudents();
        }

        private void AddNewStudent(string name, int grade)
        {
            Student student = new(name, grade);
            students.Add(student);

            LoadAllStudents();
        }

        private void AddNewStudentClick(object sender, EventArgs e)
        {
            using (AddNewStudentForm addNewStudent = new())
            {
                if (addNewStudent.ShowDialog() == DialogResult.OK)
                {
                    AddNewStudent(addNewStudent.Name, addNewStudent.Grade);
                }
            }
        }

        private Student GetSelectedStudent()
        {
            ListViewItem selectedRow = this.studentGradesView.SelectedItems[0];
            string studentName = selectedRow.SubItems[0].Text;

            return students.Where(s => s.Name == studentName).First();
        }

        private void ListViewGradesMouseClick(object sender, EventArgs e)
        {
            Student currSelectedStudent = GetSelectedStudent();

            using (StudentDetailsForm detailsPage = new(currSelectedStudent))
            {
                detailsPage.ShowDialog();
            }

            LoadAllStudents();
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
