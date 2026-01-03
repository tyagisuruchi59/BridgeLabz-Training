using System;
using System.Collections.Generic;

class Employee
{
    public string Name { get; set; }

    public Employee(string name)
    {
        Name = name;
    }
}

class Department
{
    public string DeptName { get; set; }
    public List<Employee> Employees { get; set; }

    public Department(string name)
    {
        DeptName = name;
        Employees = new List<Employee>();
    }
}

class Company
{
    public string CompanyName { get; set; }
    public List<Department> Departments { get; set; }

    public Company(string name)
    {
        CompanyName = name;
        Departments = new List<Department>();
    }
}

class Program
{
    static void Main()
    {
        Company company = new Company("TechCorp");

        Department it = new Department("IT");
        it.Employees.Add(new Employee("Amit"));

        company.Departments.Add(it);

        Console.WriteLine("Company created with departments and employees");
    }
}
