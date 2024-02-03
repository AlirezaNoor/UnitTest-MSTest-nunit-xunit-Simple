﻿using NUnit.Framework;
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
    public void Calculate_For_Input_odd_number_OutPut_False()
    {
        //Aarrnge
        Calculator cal = new();
        
        //Act
    }
}