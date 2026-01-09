using System;

class TicketNode
{
    public int Id;
    public string Name;
    public TicketNode Next;
}

class TicketSystem
{
    TicketNode tail;

    public void Book(int id, string name)
    {
        TicketNode n = new TicketNode { Id = id, Name = name };
        if (tail == null) { tail = n; n.Next = n; }
        else { n.Next = tail.Next; tail.Next = n; tail = n; }
    }

    public void Display()
    {
        if (tail == null) return;
        TicketNode t = tail.Next;
        do
        {
            Console.WriteLine($"{t.Id} {t.Name}");
            t = t.Next;
        } while (t != tail.Next);
    }
}

class Program
{
    static void Main()
    {
        TicketSystem t = new TicketSystem();
        t.Book(1, "Suru");
        t.Display();
    }
}
