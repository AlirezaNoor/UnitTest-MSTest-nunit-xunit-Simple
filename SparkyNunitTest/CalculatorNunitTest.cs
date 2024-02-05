using NUnit.Framework;
using Sparky;

namespace SparkyNunitTest;

[TestFixture]
public class CalculatorNunitTest
{
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
        //Aarrnge
        Calculator cal = new();

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
        //Aarrnge
        Calculator cal = new();

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
    [TestCase(5.4,10.5)]
    public void Calculate_TWo_Double_Number_Together(double a , double b)
    {
        //Aarrnge
        Calculator cal = new();

        //Act
        var  result = cal.AddDoubleCalculator(a,b);
        
        //Assert
        Assert.AreEqual(15.9,result,.1);
    }
}