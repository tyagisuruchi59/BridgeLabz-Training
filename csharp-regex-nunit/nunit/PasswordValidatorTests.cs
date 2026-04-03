using NUnit.Framework;
using System.Text.RegularExpressions;

public class PasswordValidator
{
    public bool IsValid(string password)
    {
        return Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*\d).{8,}$");
    }
}

[TestFixture]
public class PasswordValidatorTests
{
    [Test]
    public void Password_Test()
    {
        PasswordValidator pv = new PasswordValidator();
        Assert.IsTrue(pv.IsValid("Password1"));
        Assert.IsFalse(pv.IsValid("pass"));
    }
}
