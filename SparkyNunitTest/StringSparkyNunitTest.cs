using NUnit.Framework;
using Sparky;

namespace SparkyNunitTest;
[TestFixture]
public class StringSparkyNunitTest
{
    [Test]
    public void Check_String_return_Was_True()
    {
        StringSparky sparky = new StringSparky();
        var result=sparky.SayHellow("alireza", "Noor");
        Assert.That(result,Is.EqualTo("helllow alireza Noor"));
    }
}