using System;

class Employee
{
    public static string CompanyName = "Capgemini";
    private static int totalEmployees = 0;

    public readonly int Id;
    public string Name;
    public string Designation;

    public Employee(string name, int id, string designation)
    {
        this.Name = name;
        this.Id = id;
        this.Designation = designation;
        totalEmployees++;
    }

    public static void DisplayTotalEmployees()
    {
        Console.WriteLine("Total Employees: " + totalEmployees);
    }

    public void DisplayDetails(object obj)
    {
        if (obj is Employee)
        {
            Console.WriteLine($"{Name} - {Designation} (ID: {Id})");
        }
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee("Suru", 1, "Trainee");
        emp.DisplayDetails(emp);
        Employee.DisplayTotalEmployees();
    }
}
