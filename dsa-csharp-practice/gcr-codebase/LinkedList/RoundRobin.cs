using System;

class ProcessNode
{
    public int Id, Burst;
    public ProcessNode Next;
}

class RoundRobin
{
    ProcessNode tail;

    public void Add(int id, int burst)
    {
        ProcessNode n = new ProcessNode { Id = id, Burst = burst };
        if (tail == null) { tail = n; n.Next = n; }
        else { n.Next = tail.Next; tail.Next = n; tail = n; }
    }

    public void Execute()
    {
        if (tail == null) return;
        ProcessNode t = tail.Next;
        do
        {
            Console.WriteLine($"Process {t.Id} executed");
            t = t.Next;
        } while (t != tail.Next);
    }
}

class Program
{
    static void Main()
    {
        RoundRobin r = new RoundRobin();
        r.Add(1, 5);
        r.Add(2, 3);
        r.Execute();
    }
}
