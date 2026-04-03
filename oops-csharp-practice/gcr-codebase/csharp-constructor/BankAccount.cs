class BankAccount
{
    public int accountNumber;
    protected string accountHolder;
    private double balance;

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public double GetBalance()
    {
        return balance;
    }
}

class SavingsAccount : BankAccount
{
    public void Display()
    {
        Console.WriteLine(accountNumber + " " + accountHolder);
    }
}
