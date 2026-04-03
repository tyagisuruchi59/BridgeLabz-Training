using System;

class TaskNode
{
    public int Id;
    public string Name;
    public TaskNode Next;

    public TaskNode(int id, string name)
    {
        Id = id; Name = name;
    }
}

class TaskList
{
    private TaskNode tail;

    public void AddTask(int id, string name)
    {
        TaskNode node = new TaskNode(id, name);
        if (tail == null)
        {
            tail = node;
            tail.Next = tail;
        }
        else
        {
            node.Next = tail.Next;
            tail.Next = node;
            tail = node;
        }
    }

    public void Display()
    {
        if (tail == null) return;
        TaskNode t = tail.Next;
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
        TaskList list = new TaskList();
        list.AddTask(1, "Task1");
        list.AddTask(2, "Task2");
        list.Display();
    }
}
