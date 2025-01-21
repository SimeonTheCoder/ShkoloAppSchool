public class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
    public int ExcusedAbscences { get; set; }
    public int UnexcusedAbscences { get; set; }

    public int TotalAbscences => this.ExcusedAbscences + this.UnexcusedAbscences;

    public List<double> MathematicsGrades { get; set; } = new();
    public List<double> InformaticsGrades { get; set; } = new();
    public List<double> SportGrades { get; set; } = new();

    public double AverageMark
    {
        get
        {
            var allMarks = MathematicsGrades.Concat(InformaticsGrades ?? Enumerable.Empty<double>())
                                            .Concat(SportGrades ?? Enumerable.Empty<double>());

            return allMarks.Any() ? allMarks.Average() : 0;
        }
    }

    public Student (string name, int grade)
    {
        this.Name = name;
        this.Grade = grade;
    }

    public Student (string name, int grade, List<double> mathGrades, List<double> infGrades, List<double> sportGrades)
    {
        this.Name = name;
        this.Grade = grade;
        this.MathematicsGrades = mathGrades;
        this.InformaticsGrades = infGrades;
        this.SportGrades = sportGrades;
    }
}