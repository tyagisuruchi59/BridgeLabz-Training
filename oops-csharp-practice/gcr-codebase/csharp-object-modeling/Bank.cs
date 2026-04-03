using System;

class Bank
{
    public string BankName { get; set; }

    public Bank(string name)
    {
        BankName = name;
    }

    public void OpenAccount(Customer customer)
    {
        Console.WriteLine($"Account opened for {customer.Name} in {BankName}");
    }
}

class Customer
{
    public string Name { get; set; }
    public double Balance { get; set; }

    public Customer(string name, double balance)
    {
        Name = name;
        Balance = balance;
    }

    public void ViewBalance()
    {
        Console.WriteLine($"{Name}'s Balance: {Balance}");
    }
}

class Program
{
    static void Main()
    {
        Bank bank = new Bank("SBI");
        Customer customer = new Customer("Rahul", 5000);

        bank.OpenAccount(customer);
        customer.ViewBalance();
    }
}
