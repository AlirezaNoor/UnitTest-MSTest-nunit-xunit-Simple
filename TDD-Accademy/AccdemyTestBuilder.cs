namespace TDD_Accademy;

public class AccdemyTestBuilder
{
    int id = 1;
    string name = "Student";
    bool isOnlion = true;
    double tuition = 1000;
    string Teacher = "Alireza";
    public AccdemyTestBuilder withName(string name)
    {
        this.name = name;
        return this;
    }

    public AccdemyTestBuilder WtihTurtion(double tuition)
    {
        this.tuition = tuition;
        return this;
    }

    public AccdemyClass builde()
    {
        return new AccdemyClass(id, name, isOnlion, tuition,Teacher);
    }
}