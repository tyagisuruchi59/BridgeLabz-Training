using System;

class Book
{
    public static string LibraryName = "Central Library";

    public readonly string ISBN;
    public string Title;
    public string Author;

    public Book(string title, string author, string isbn)
    {
        this.Title = title;
        this.Author = author;
        this.ISBN = isbn;
    }

    public static void DisplayLibraryName()
    {
        Console.WriteLine("Library: " + LibraryName);
    }

    public void DisplayDetails(object obj)
    {
        if (obj is Book)
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
        }
    }
}

class Program
{
    static void Main()
    {
        Book book = new Book("C# Basics", "Microsoft", "ISBN123");
        Book.DisplayLibraryName();
        book.DisplayDetails(book);
    }
}
