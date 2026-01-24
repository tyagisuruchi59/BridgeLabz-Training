using NUnit.Framework;
using System;

public class StringUtils
{
    public string Reverse(string str)
    {
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    public bool IsPalindrome(string str)
    {
        return str.Equals(Reverse(str), StringComparison.OrdinalIgnoreCase);
    }

    public string ToUpperCase(string str) => str.ToUpper();
}

[TestFixture]
public class StringUtilsTests
{
    StringUtils utils;

    [SetUp]
    public void Setup()
    {
        utils = new StringUtils();
    }

    [Test] public void Reverse_Test() => Assert.AreEqual("olleh", utils.Reverse("hello"));
    [Test] public void Palindrome_Test() => Assert.IsTrue(utils.IsPalindrome("madam"));
    [Test] public void Uppercase_Test() => Assert.AreEqual("HELLO", utils.ToUpperCase("hello"));
}
