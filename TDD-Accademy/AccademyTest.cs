using Xunit;

namespace TDD_Accademy;

public class AccademyTest
{
    [Fact]
    public void Accemy_Constructor_checker()
    {
        const int id = 1;
        const string name = "Student";
        const bool isOnlion = true;
        const double tuition = 1000;

        AccdemyClass accdemyClass = new AccdemyClass(id, name, isOnlion, tuition);
        Assert.Equal(id, accdemyClass.Id);
        Assert.Equal(name, accdemyClass.Name);
        Assert.Equal(tuition, accdemyClass.Tuition);
        Assert.Equal(isOnlion, accdemyClass.IsOnline);
    }
}

public class AccdemyClass
{
    public AccdemyClass(int id, string student, bool isOnlion, double tuition)
    {
        Id = id;
        IsOnline = isOnlion;
        Name = student;
        Tuition = tuition;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public double Tuition { get; set; }
    public bool IsOnline { get; set; }
}