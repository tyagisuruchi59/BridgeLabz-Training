using System;

class UserNode
{
    public int Id;
    public string Name;
    public UserNode Next;
}

class Social
{
    UserNode head;

    public void Add(int id, string name)
    {
        UserNode n = new UserNode { Id = id, Name = name, Next = head };
        head = n;
    }

    public void Display()
    {
        UserNode t = head;
        while (t != null)
        {
            Console.WriteLine($"{t.Id} {t.Name}");
            t = t.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        Social s = new Social();
        s.Add(1, "A");
        s.Display();
    }
}
