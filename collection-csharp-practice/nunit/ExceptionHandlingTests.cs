using NUnit.Framework;
using System;

[TestFixture]
public class ExceptionHandlingTests
{
    [Test]
    public void Divide_By_Zero_Should_Throw()
    {
        Calculator calc = new Calculator();
        Assert.Throws<ArithmeticException>(() => calc.Divide(5, 0));
    }
}
