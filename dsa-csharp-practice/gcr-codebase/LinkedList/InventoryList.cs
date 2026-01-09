using System;

class ItemNode
{
    public int Id, Qty;
    public string Name;
    public double Price;
    public ItemNode Next;
}

class Inventory
{
    ItemNode head;

    public void Add(int id, string name, int q, double p)
    {
        ItemNode n = new ItemNode { Id = id, Name = name, Qty = q, Price = p };
        n.Next = head;
        head = n;
    }

    public void TotalValue()
    {
        double sum = 0;
        ItemNode t = head;
        while (t != null)
        {
            sum += t.Qty * t.Price;
            t = t.Next;
        }
        Console.WriteLine("Total Value: " + sum);
    }
}

class Program
{
    static void Main()
    {
        Inventory i = new Inventory();
        i.Add(1, "Pen", 10, 5);
        i.TotalValue();
    }
}
