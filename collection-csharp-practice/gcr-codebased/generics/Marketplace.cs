using System;
using System.Collections.Generic;

abstract class Product
{
    public string Title { get; set; }
    public double Price { get; set; }
}

class Book : Product { }
class Clothing : Product { }

class Catalog<T> where T : Product
{
    public List<T> Products = new List<T>();
}

class DiscountService
{
    public static void ApplyDiscount<T>(T product, double percentage)
        where T : Product
    {
        product.Price -= product.Price * percentage / 100;
    }
}
