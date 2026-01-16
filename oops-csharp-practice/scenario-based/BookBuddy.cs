using System;
using System.Collections;

// Custom Exception
class InvalidBookFormatException : Exception
{
    public InvalidBookFormatException(string message) : base(message)
    {
    }
}

class BookBuddy
{
    private ArrayList books = new ArrayList(); // "Title - Author"

    // Add book
    public void AddBook(string title, string author)
    {
        if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
        {
            throw new InvalidBookFormatException("Title or Author cannot be empty");
        }

        string bookEntry = title + " - " + author;
        books.Add(bookEntry);

        Console.WriteLine("Book added successfully");
    }

    // Sort books alphabetically
    public void SortBooksAlphabetically()
    {
        try
        {
            if (books.Count == 0)
                throw new Exception("Book list is empty");

            books.Sort();
            Console.WriteLine("Books sorted alphabetically");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    // Search books by author
    public void SearchByAuthor(string author)
    {
        bool found = false;

        try
        {
            if (books.Count == 0)
                throw new Exception("No books available to search");

            foreach (string book in books)
            {
                // Split "Title - Author"
                string[] parts = book.Split('-');

                if (parts.Length != 2)
                {
                    throw new InvalidBookFormatException(
                        "Invalid book format found: " + book);
                }

                string bookAuthor = parts[1].Trim();

                if (bookAuthor.Contains(author))
                {
                    Console.WriteLine("Found: " + book);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No books found by author: " + author);
            }
        }
        catch (InvalidBookFormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    // Convert ArrayList to array before exporting
    public void ExportBooks()
    {
        try
        {
            if (books.Count == 0)
                throw new Exception("No books to export");

            string[] bookArray = (string[])books.ToArray(typeof(string));

            Console.WriteLine("\n--- Exported Book List ---");
            foreach (string book in bookArray)
            {
                Console.WriteLine(book);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

class Program
{
    static void Main()
    {
        BookBuddy bookshelf = new BookBuddy();

        try
        {
            bookshelf.AddBook("Clean Code", "Robert Martin");
            bookshelf.AddBook("Effective Java", "Joshua Bloch");
            bookshelf.AddBook("The Pragmatic Programmer", "Andy Hunt");
        }
        catch (InvalidBookFormatException ex)
        {
            Console.WriteLine(ex.Message);
        }

        bookshelf.SortBooksAlphabetically();

        Console.WriteLine();
        bookshelf.SearchByAuthor("Joshua");

        bookshelf.ExportBooks();
    }
}
