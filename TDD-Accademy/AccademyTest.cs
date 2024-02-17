using FluentAssertions;
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
        const string teacher = "Alireza";
        AccdemyTestBuilder testBuilder = new AccdemyTestBuilder();
        var accdemyClass = testBuilder.builde();
        accdemyClass.Id.Should().Be(id);
        accdemyClass.Name.Should().Be(name);
        accdemyClass.IsOnline.Should().Be(isOnlion);
        accdemyClass.Tuition.Should().Be(tuition);
        accdemyClass.Teacher.Should().Be(teacher);
        accdemyClass.Section.Should().BeEmpty();
    }

    [Fact]
    public void Accdemy_null_or_emty_name_property_in_Constructor()
    {
        AccdemyTestBuilder testBuilder = new AccdemyTestBuilder();
        Action Accdemyclass = () => testBuilder.withName("").builde();
        Accdemyclass.Should().ThrowExactly<MyCustomExcption>() ;
    }

    [Fact]
    public void Accdemy_Tution_Throw_exption_when_smaller_or_0()
    {
        AccdemyTestBuilder testBuilder = new();
        Action _Accdemy = () => testBuilder.WtihTurtion(0).builde();
        _Accdemy.Should().ThrowExactly<MyCustomExcption>() ;;
    }

    [Fact]
    public void Accedmey_must_Add_to_Section_when_we_pass_id_And_Name()
    {
        AccdemyTestBuilder testBuilder = new();
        var result = testBuilder.builde();

        const int id = 1;
        const string name = "Alireza";
        Sectionclass sectionclass = new Sectionclass(id, name);
        result.AddAction(sectionclass);

        result.Section.Should().ContainEquivalentOf(sectionclass);

    }
}

