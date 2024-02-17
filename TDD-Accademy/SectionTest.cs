using FluentAssertions;
using Xunit;

namespace TDD_Accademy;

public class SectionTest
{
    [Fact]
    public void Check_section()
    {
        const int id = 1;
        const string name = "Alireza";

        Sectionclass sectionclass = new Sectionclass(id, name);
        sectionclass.Id.Should().Be(id);
        sectionclass.Name.Should().Be(name);
    }
}