using System;

class Product
{
    public static double Discount = 10;

    public readonly int ProductID;
    public string ProductName;
    public double Price;
    public int Quantity;

    public Product(string productName, double price, int quantity, int productId)
    {
        this.ProductName = productName;
        this.Price = price;
        this.Quantity = quantity;
        this.ProductID = productId;
    }

    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
    }

    public void DisplayProduct(object obj)
    {
        if (obj is Product)
        {
            Console.WriteLine($"{ProductName} - ₹{Price}, Qty: {Quantity}, ID: {ProductID}");
        }
    }
}

class Program
{
    static void Main()
    {
        Product p = new Product("Laptop", 50000, 1, 501);
        p.DisplayProduct(p);
    }
}
