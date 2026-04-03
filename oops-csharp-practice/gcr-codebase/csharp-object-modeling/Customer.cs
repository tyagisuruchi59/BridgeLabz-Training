using System;
using System.Collections.Generic;

class Product
{
    public string ProductName { get; set; }
    public double Price { get; set; }
}

class Order
{
    public List<Product> Products { get; set; } = new List<Product>();
}

class Customer
{
    public string Name { get; set; }

    public void PlaceOrder(Order order)
    {
        Console.WriteLine($"{Name} placed an order");
    }
}
