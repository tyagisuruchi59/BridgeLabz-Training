using System;
using System.Collections.Generic;

abstract class WarehouseItem
{
    public string Name { get; set; }
}

class Electronics : WarehouseItem { }
class Groceries : WarehouseItem { }
class Furniture : WarehouseItem { }

class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void DisplayItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item.Name);
        }
    }
}
