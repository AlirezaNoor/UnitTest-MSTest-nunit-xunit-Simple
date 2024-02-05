using System.Text.RegularExpressions;
using NUnit.Framework;
using Sparky;

namespace SparkyNunitTest;

[TestFixture]
public class StringSparkyNunitTest
{
    private StringSparky stringSparky;


    [SetUp]
    public void Setup()
    {
        stringSparky = new StringSparky();
    }

    [Test]
    public void Check_String_return_Was_True()
    {
        StringSparky sparky = new StringSparky();
        var result = sparky.SayHellow("alireza", "Noor");
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.EqualTo("helllow alireza Noor"));
            Assert.That(result, Does.Contain("ali").IgnoreCase);
            Assert.That(result, Does.StartWith("helllow"));
            Assert.That(result, Does.Match("helllow [a-z]"));
        });
    }

    [Test]
    public void Check_null_Value_Is_True()
    {
        StringSparky sparky = new StringSparky();
        Assert.IsNull(sparky.GenerateName);
    }

    [Test]
    public void GreetCheacker_EmptyFirstName_ThrowExcetion()
    {
        stringSparky.FullName("alireza", "");
        Assert.IsNotNull(stringSparky.GenerateName);
        Assert.IsFalse(string.IsNullOrEmpty(stringSparky.GenerateName));
    }

    [Test]
    public void GreetCheacker_EmptyFirstName_ThrowExcetion_2()
    {
        var expetion = Assert.Throws<ArgumentException>(() =>
            stringSparky.FullName("", "Alireza"));
        Assert.AreEqual("Empty first Name", expetion.Message);
        Assert.That(() => stringSparky.FullName("", "test"),
            Throws.ArgumentException.With.Message.EqualTo("Empty first Name"));
    }

    [Test]
    public void Customer_CreateCustomerWithLessThen100_ReturnBasicCustomer()
    {
        stringSparky.totalorder = 10;
        var Result = stringSparky.GetCustomerDatails();
        Assert.That(Result, Is.TypeOf<BasicCustomer>());
    }

    [Test]
    public void Customer_CreateCustomerWithMore_Then100_ReturnBasicCustomer()
    {
        stringSparky.totalorder = 110;
        var Result = stringSparky.GetCustomerDatails();
        Assert.That(Result, Is.TypeOf<PlatformCustomer>());
    }
}