using System;
using System.Collections.Generic;

interface ILoanable
{
    void ApplyForLoan();
    double CalculateLoanEligibility();
}

abstract class BankAccount
{
    private string accountNumber;
    private string holderName;
    protected double balance;

    protected BankAccount(string acc, string name, double balance)
    {
        accountNumber = acc;
        holderName = name;
        this.balance = balance;
    }

    public void Deposit(double amount) => balance += amount;
    public void Withdraw(double amount) => balance -= amount;

    public abstract double CalculateInterest();
}

class SavingsAccount : BankAccount
{
    public SavingsAccount(string acc, string name, double bal)
        : base(acc, name, bal) { }

    public override double CalculateInterest() => balance * 0.04;
}

class Program
{
    static void Main()
    {
        BankAccount account = new SavingsAccount("SB101", "Ravi", 50000);
        Console.WriteLine($"Interest: {account.CalculateInterest()}");
    }
}
