using System;
using System.Collections.Generic;

interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

abstract class Product
{
    private int productId;
    private string name;
    protected double price;

    protected Product(int id, string name, double price)
    {
        productId = id;
        this.name = name;
        this.price = price;
    }

    public abstract double CalculateDiscount();

    public double GetFinalPrice(ITaxable tax)
    {
        return price + tax.CalculateTax() - CalculateDiscount();
    }
}

class Electronics : Product, ITaxable
{
    public Electronics(int id, string name, double price)
        : base(id, name, price) { }

    public override double CalculateDiscount() => price * 0.10;
    public double CalculateTax() => price * 0.18;
    public string GetTaxDetails() => "GST 18%";
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Electronics(1, "Laptop", 60000)
        };

        foreach (Product p in products)
        {
            ITaxable tax = (ITaxable)p;
            Console.WriteLine($"Final Price: {p.GetFinalPrice(tax)}");
        }
    }
}
