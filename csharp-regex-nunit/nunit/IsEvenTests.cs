using NUnit.Framework;

public class NumberUtils
{
    public bool IsEven(int number) => number % 2 == 0;
}

[TestFixture]
public class IsEvenTests
{
    NumberUtils utils = new NumberUtils();

    [TestCase(2, true)]
    [TestCase(4, true)]
    [TestCase(6, true)]
    [TestCase(7, false)]
    [TestCase(9, false)]
    public void IsEven_Test(int value, bool expected)
    {
        Assert.AreEqual(expected, utils.IsEven(value));
    }
}
