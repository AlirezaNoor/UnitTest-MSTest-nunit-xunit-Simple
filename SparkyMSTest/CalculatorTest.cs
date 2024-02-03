using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sparky;

namespace SparkyMSTest;

[TestClass]
public class CalculatorTest
{
    [TestMethod]
    public void Calulate_Two_number_Toghether()
    {
        //Aarrnge
        Calculator cal = new();
        //Act
       int result= cal.AddCalculater(10,20);
        //Assert
        Assert.AreEqual(30,result);
    }
}