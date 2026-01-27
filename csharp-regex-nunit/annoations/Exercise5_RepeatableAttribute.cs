using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReportAttribute : Attribute
{
    public string Description { get; }
    public BugReportAttribute(string desc)
    {
        Description = desc;
    }
}

class TestApp
{
    [BugReport("Null reference issue")]
    [BugReport("Performance issue")]
    public void Run() { }
}

class Program
{
    static void Main()
    {
        var bugs = typeof(TestApp).GetMethod("Run")
            .GetCustomAttributes(typeof(BugReportAttribute), false);

        foreach (BugReportAttribute bug in bugs)
            Console.WriteLine(bug.Description);
    }
}
