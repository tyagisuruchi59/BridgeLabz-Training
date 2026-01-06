using System;
using System.Collections.Generic;

interface IReservable
{
    void ReserveItem();
    bool CheckAvailability();
}

abstract class LibraryItem
{
    protected int itemId;
    protected string title;
    protected string author;

    protected LibraryItem(int id, string title, string author)
    {
        itemId = id;
        this.title = title;
        this.author = author;
    }

    public abstract int GetLoanDuration();

    public void GetItemDetails()
    {
        Console.WriteLine($"{title} by {author}");
    }
}

class Book : LibraryItem
{
    public Book(int id, string title, string author)
        : base(id, title, author) { }

    public override int GetLoanDuration() => 14;
}

class Program
{
    static void Main()
    {
        LibraryItem item = new Book(1, "C# Basics", "MS");
        item.GetItemDetails();
    }
}
