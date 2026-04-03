using NUnit.Framework;
using System;

public class BankAccount
{
    double balance;

    public void Deposit(double amount) => balance += amount;

    public void Withdraw(double amount)
    {
        if (amount > balance)
            throw new InvalidOperationException();
        balance -= amount;
    }

    public double GetBalance() => balance;
}

[TestFixture]
public class BankAccountTests
{
    [Test]
    public void Deposit_Test()
    {
        BankAccount acc = new BankAccount();
        acc.Deposit(100);
        Assert.AreEqual(100, acc.GetBalance());
    }

    [Test]
    public void Withdraw_Fail_Test()
    {
        BankAccount acc = new BankAccount();
        Assert.Throws<InvalidOperationException>(() => acc.Withdraw(50));
    }
}
