namespace TDD_Accademy;

public class AccdemyClass
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Tuition { get; set; }
    public bool IsOnline { get; set; }
    public string Teacher { get; set; }
    public List<Sectionclass> Section { get; set; }

    public AccdemyClass(int id, string student, bool isOnlion, double tuition, string teacher)
    {
        StudentnameNullchecker(student);
        TutiionThrowExption(tuition);
        Id = id;
        IsOnline = isOnlion;
        Name = student;
        Tuition = tuition;
        Teacher = teacher;
        Section = new List<Sectionclass>();
    }

    private static void TutiionThrowExption(double tuition)
    {
        if (tuition <= 0)
        {
            throw new MyCustomExcption();
        }
    }

    private static void StudentnameNullchecker(string student)
    {
        if (string.IsNullOrWhiteSpace(student))
        {
            throw new MyCustomExcption();
        }
    }

    public void AddAction(Sectionclass sectionclass)
    {
        Section.Add(sectionclass);
    }
}