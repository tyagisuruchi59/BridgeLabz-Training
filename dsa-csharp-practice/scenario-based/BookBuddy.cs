using System;
using System.Collections;
using System.Linq;

namespace BookBuddy
{
    //  CUSTOM EXCEPTION 
    public class InvalidBookFormatException : Exception
    {
        public InvalidBookFormatException(string message) : base(message) { }
    }

    //  BOOK MANAGER 
    public class BookManager
    {
        // ArrayList storing "Title - Author"
        private ArrayList books = new ArrayList();

        // ADD BOOK
        public void AddBook(string title, string author)
        {
            books.Add($"{title} - {author}");
        }

        //  SORT BOOKS 
        public void SortBooksAlphabetically()
        {
            try
            {
                if (books.Count == 0)
                    throw new Exception("Bookshelf is empty");

                books.Sort();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sort Error: " + ex.Message);
            }
        }

        //  SEARCH BY AUTHOR 
        public void SearchByAuthor(string author)
        {
            try
            {
                if (books.Count == 0)
                    throw new Exception("Bookshelf is empty");

                bool found = false;

                foreach (string book in books)
                {
                    // Using String.Split()
                    string[] parts = book.Split(" - ");

                    if (parts.Length != 2)
                        throw new InvalidBookFormatException(
                            "Invalid book format: " + book
                        );

                    string bookAuthor = parts[1];

                    if (bookAuthor.Equals(author, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("📖 " + book);
                        found = true;
                    }
                }

                if (!found)
                    Console.WriteLine("No books found for author: " + author);
            }
            catch (InvalidBookFormatException ex)
            {
                Console.WriteLine("Format Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Search Error: " + ex.Message);
            }
        }

        //  DISPLAY ALL BOOKS 
        public void DisplayAllBooks()
        {
            try
            {
                if (books.Count == 0)
                    throw new Exception("Bookshelf is empty");

                Console.WriteLine("\n Your Bookshelf:");
                foreach (string book in books)
                {
                    Console.WriteLine(book);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Display Error: " + ex.Message);
            }
        }

        //  EXPORT (ArrayList → Array) 
        public void ExportBooks()
        {
            Console.WriteLine("\n Exporting Books:");

            string[] bookArray = books.Cast<string>().ToArray();

            foreach (string book in bookArray)
            {
                Console.WriteLine(book);
            }
        }
    }

    // MAIN PROGRAM 
    class Program
    {
        static void Main(string[] args)
        {
            BookManager manager = new BookManager();

            // Add books
            manager.AddBook("Clean Code", "Robert Martin");
            manager.AddBook("Effective Java", "Joshua Bloch");
            manager.AddBook("Design Patterns", "Erich Gamma");

            // Display
            manager.DisplayAllBooks();

            // Sort
            manager.SortBooksAlphabetically();
            manager.DisplayAllBooks();

            // Search
            Console.WriteLine("\n Search by Author:");
            manager.SearchByAuthor("Joshua Bloch");

            // Export
            manager.ExportBooks();
        }
    }
}
using System;
using System.Collections;

// Custom Exception
public class InvalidBookFormatException : Exception
{
    public InvalidBookFormatException(string message) : base(message) { }
}

// Book Manager
public class BookManager
{
    // ArrayList storing "Title - Author"
    private ArrayList books = new ArrayList();

    // Add book
    public void AddBook(string title, string author)
    {
        books.Add(title + " - " + author);
    }

    // Sort books alphabetically
    public void SortBooksAlphabetically()
    {
        try
        {
            if (books.Count == 0)
                throw new Exception("Bookshelf is empty");

            books.Sort();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    // Search books by author
    public void SearchByAuthor(string author)
    {
        try
        {
            if (books.Count == 0)
                throw new Exception("Bookshelf is empty");

            bool found = false;

            foreach (string book in books)
            {
                string[] parts = book.Split(" - ");

                if (parts.Length != 2)
                    throw new InvalidBookFormatException("Invalid book format: " + book);

                string bookAuthor = parts[1];

                if (bookAuthor.Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(book);
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("No books found for author: " + author);
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

    // Display all books
    public void DisplayAllBooks()
    {
        try
        {
            if (books.Count == 0)
                throw new Exception("Bookshelf is empty");

            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    // Export books (ArrayList to array)
    public void ExportBooks()
    {
        string[] bookArray = (string[])books.ToArray(typeof(string));

        foreach (string book in bookArray)
        {
            Console.WriteLine(book);
        }
    }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        BookManager manager = new BookManager();

        manager.AddBook("Clean Code", "Robert Martin");
        manager.AddBook("Effective Java", "Joshua Bloch");
        manager.AddBook("Design Patterns", "Erich Gamma");

        manager.DisplayAllBooks();
        manager.SortBooksAlphabetically();
        manager.DisplayAllBooks();

        manager.SearchByAuthor("Joshua Bloch");

        manager.ExportBooks();
    }
}
