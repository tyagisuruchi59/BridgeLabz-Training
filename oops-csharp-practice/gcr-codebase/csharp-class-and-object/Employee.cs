using System;

class Employee
{
    // Attributes
    string name;
    int id;
    double salary;

    // Constructor
    public Employee(string name, int id, double salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    // Method to display employee details
    public void DisplayDetails()
    {
        Console.WriteLine("Employee Name: " + name);
        Console.WriteLine("Employee ID: " + id);
        Console.WriteLine("Salary: " + salary);
    }

    static void Main()
    {
        Employee emp = new Employee("Suru", 101, 45000);
        emp.DisplayDetails();
    }
}
