using System;
using BYT3_Part_Two;
using NUnit.Framework;

namespace BYT3_Part_Two.Tests;


public class CalculatorTest
{

    [Test]
    public void TestAddition()
    {
        var calc = new Calculator(10, 5, "+");
        Assert.That(calc.Calculate(), Is.EqualTo(15.0));
    }

    [Test]
    public void TestSubtraction()
    {
        var calc = new Calculator(10, 5, "-");
        Assert.That(calc.Calculate(), Is.EqualTo(5.0));
    }

    [Test]
    public void TestMultiplication()
    {
        var calc = new Calculator(10, 5, "*");
        Assert.That(calc.Calculate(), Is.EqualTo(50.0));
    }

    [Test]
    public void TestDivision()
    {
        var calc = new Calculator(10, 5, "/");
        Assert.That(calc.Calculate(), Is.EqualTo(2.0));
    }

    [Test]
    public void TestDivisionByZero()
    {
        var calc = new Calculator(10, 0, "/");
        Assert.Throws(typeof(DivideByZeroException), () => calc.Calculate());
    }

    [Test]
    public void TestUnknownOperation()
    {
        var calc = new Calculator(10, 5, "^");
        Assert.Throws(typeof(InvalidOperationException), () => calc.Calculate());
    }
}