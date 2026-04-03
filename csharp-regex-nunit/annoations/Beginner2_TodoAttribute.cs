using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class TodoAttribute : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

class Project
{
    [Todo("Fix login", "Suru", "HIGH")]
    [Todo("Improve UI", "Alex")]
    public void Work() { }
}

class Program
{
    static void Main()
    {
        var todos = typeof(Project).GetMethod("Work")
            .GetCustomAttributes<TodoAttribute>();

        foreach (var t in todos)
            Console.WriteLine($"{t.Task} - {t.AssignedTo} - {t.Priority}");
    }
}
