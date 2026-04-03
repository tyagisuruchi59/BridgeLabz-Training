using System;
using System.Collections.Generic;

interface IDiscountable
{
    double ApplyDiscount();
    string GetDiscountDetails();
}

abstract class FoodItem
{
    protected string itemName;
    protected double price;
    protected int quantity;

    protected FoodItem(string name, double price, int qty)
    {
        itemName = name;
        this.price = price;
        quantity = qty;
    }

    public abstract double CalculateTotalPrice();
}

class NonVegItem : FoodItem
{
    public NonVegItem(string name, double price, int qty)
        : base(name, price, qty) { }

    public override double CalculateTotalPrice()
    {
        return (price * quantity) + 50;
    }
}

class Program
{
    static void Main()
    {
        FoodItem item = new NonVegItem("Chicken Biryani", 250, 2);
        Console.WriteLine(item.CalculateTotalPrice());
    }
}
