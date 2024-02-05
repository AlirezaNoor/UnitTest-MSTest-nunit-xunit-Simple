using NUnit.Framework;
using Sparky;

namespace SparkyNunitTest;

[TestFixture]
public class CalculatorNunitTest
{
    private Calculator cal;

    [SetUp]
    public void Setup()
    {
        cal = new Calculator();
    }

    [Test]
    public void Calulate_Two_number_Toghether()
    {
        //Aarrnge
        Calculator cal = new();
        //Act
        int result = cal.AddCalculater(10, 20);
        //Assert
        Assert.AreEqual(30, result);
    }

    [Test]
    [TestCase(10)]
    [TestCase(200)]
    public void Calculate_For_Input_Not_odd_number_OutPut_False(int a)
    {
   

        //Act
        bool result = cal.OddNumberCalculate(a);

        //Assert

        Assert.That(result, Is.EqualTo(false));
        Assert.IsFalse(result);
    }

    [Test]
    [TestCase(11)]
    [TestCase(21)]
    public void Calculate_Input_OddNummber_OutPut_True(int a)
    {
 

        //Act
        bool result = cal.OddNumberCalculate(a);

        //Assert
        Assert.That(result, Is.EqualTo(true));
        Assert.IsTrue(result);
    }

    [Test]
    [TestCase(11, ExpectedResult = true)]
    public bool Calculate_Input_OddNummber_True(int a)
    {
        //Aarrnge
        Calculator cal = new();

        //Act
        bool result = cal.OddNumberCalculate(a);

        return result;
    }

    [Test]
    [TestCase(5.4, 10.5)]
    public void Calculate_TWo_Double_Number_Together(double a, double b)
    {
        //Aarrnge
 

        //Act
        var result = cal.AddDoubleCalculator(a, b);

        //Assert
        Assert.AreEqual(15.9, result, .1);
    }

    [Test]
    public void Calculate_Lsit_Of_Number_That_odd_Number()
    {
 

        List<int> Input = new List<int>() { 5, 7, 9 };
        var result = cal.Add_Oddnumber_To_List(4, 10);
        Assert.That(result,Is.EquivalentTo(Input));
    }
 
}