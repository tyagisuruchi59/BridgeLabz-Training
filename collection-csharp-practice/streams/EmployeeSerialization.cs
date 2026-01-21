using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class EmployeeSerialization
{
    static void Main()
    {
        string file = "employees.json";

        List<Employee> list = new List<Employee>
        {
            new Employee{ Id=1, Name="Suru", Department="IT", Salary=50000 },
            new Employee{ Id=2, Name="Amit", Department="HR", Salary=40000 }
        };

        string json = JsonSerializer.Serialize(list);
        File.WriteAllText(file, json);

        var employees = JsonSerializer.Deserialize<List<Employee>>(File.ReadAllText(file));

        foreach (var e in employees)
        {
            Console.WriteLine($"{e.Id} {e.Name} {e.Department} {e.Salary}");
        }
    }
}
