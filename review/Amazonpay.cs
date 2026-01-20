using System;

internal class AmazonPay
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter role :");
        string inputRole = Console.ReadLine();

        Gateway gateway = new Gateway();

        if (inputRole == "vipPerson")
        {
            Console.WriteLine("VIP User Detected");    
        }
        else
        {
            Console.WriteLine("Normal User Detected");
        }
    }
}

public class Gateway
{
    public void Payment(double amount, string  transfer, bool isVip)
    {
        Console.WriteLine("Processing Payment");
        if (isVip)
        {
            double discount = amount * 0.20;
            amount = amount - discount;
            Console.WriteLine("VIP Discount Applied: 20%");
            Console.WriteLine("Discount Amount: " + discount);
        }

        Console.WriteLine("Final Amount: " + amount);

        switch (transfer)
        {
           case "Upi":
           Console.WriteLine("payment done");
        }
    }