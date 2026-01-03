using System;

class BankAccount
{
    // static variable shared by all accounts
    public static string BankName = "ABC Bank";
    private static int totalAccounts = 0;

    // readonly variable (cannot change once assigned)
    public readonly int AccountNumber;

    public string AccountHolderName;

    // Constructor using 'this'
    public BankAccount(string accountHolderName, int accountNumber)
    {
        this.AccountHolderName = accountHolderName;
        this.AccountNumber = accountNumber;
        totalAccounts++;
    }

    // static method
    public static void GetTotalAccounts()
    {
        Console.WriteLine("Total Accounts: " + totalAccounts);
    }

    public void DisplayDetails(object obj)
    {
        if (obj is BankAccount)
        {
            Console.WriteLine($"Bank: {BankName}");
            Console.WriteLine($"Holder: {AccountHolderName}");
            Console.WriteLine($"Account No: {AccountNumber}");
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc1 = new BankAccount("Suru", 101);
        acc1.DisplayDetails(acc1);
        BankAccount.GetTotalAccounts();
    }
}
