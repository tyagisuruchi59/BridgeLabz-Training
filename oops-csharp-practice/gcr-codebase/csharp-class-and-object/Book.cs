using System;

class Book
{
    string title;
    string author;
    double price;

    // Constructor
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    // Method to display book details
    public void DisplayBookDetails()
    {
        Console.WriteLine("Book Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }

    static void Main()
    {
        Book book = new Book("Clean Code", "Robert C. Martin", 550);
        book.DisplayBookDetails();
    }
}
