using System;
using System.Collections.Generic;

interface IDepartment
{
    void AssignDepartment(string department);
    string GetDepartmentDetails();
}

abstract class Employee
{
    private int employeeId;
    private string name;
    protected double baseSalary;

    public int EmployeeId => employeeId;
    public string Name => name;

    protected Employee(int id, string name, double salary)
    {
        employeeId = id;
        this.name = name;
        baseSalary = salary;
    }

    public abstract double CalculateSalary();

    public void DisplayDetails()
    {
        Console.WriteLine($"ID: {EmployeeId}, Name: {Name}, Salary: {CalculateSalary()}");
    }
}

class FullTimeEmployee : Employee, IDepartment
{
    private string department;

    public FullTimeEmployee(int id, string name, double salary)
        : base(id, name, salary) { }

    public override double CalculateSalary() => baseSalary;

    public void AssignDepartment(string department) => this.department = department;
    public string GetDepartmentDetails() => department;
}

class PartTimeEmployee : Employee
{
    private int hours;
    private double rate;

    public PartTimeEmployee(int id, string name, int hours, double rate)
        : base(id, name, 0)
    {
        this.hours = hours;
        this.rate = rate;
    }

    public override double CalculateSalary() => hours * rate;
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new FullTimeEmployee(1, "Ravi", 50000),
            new PartTimeEmployee(2, "Anita", 20, 500)
        };

        foreach (Employee emp in employees)
        {
            emp.DisplayDetails();
        }
    }
}
