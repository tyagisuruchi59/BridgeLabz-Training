using System;

class Employee
{
    public string Name;
    public int Id;
    public double Salary;

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Id: {Id}, Salary: {Salary}");
    }
}

class Manager : Employee
{
    public int TeamSize;

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Team Size: " + TeamSize);
    }
}

class Developer : Employee
{
    public string ProgrammingLanguage;

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Language: " + ProgrammingLanguage);
    }
}

class Intern : Employee
{
    public string InternshipDuration;

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Duration: " + InternshipDuration);
    }
}
