using System;

class BookNode
{
    public int Id;
    public string Title, Author;
    public BookNode Prev, Next;
}

class Library
{
    BookNode head;

    public void Add(int id, string t, string a)
    {
        BookNode n = new BookNode { Id = id, Title = t, Author = a };
        if (head != null) { head.Prev = n; n.Next = head; }
        head = n;
    }

    public void Display()
    {
        BookNode t = head;
        while (t != null)
        {
            Console.WriteLine($"{t.Id} {t.Title}");
            t = t.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        Library l = new Library();
        l.Add(1, "C#", "MS");
        l.Display();
    }
}
