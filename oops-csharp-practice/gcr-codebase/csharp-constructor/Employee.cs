class Employee
{
    public int employeeID;
    protected string department;
    private double salary;

    public void SetSalary(double salary)
    {
        this.salary = salary;
    }

    public double GetSalary()
    {
        return salary;
    }
}

class Manager : Employee
{
    public void Display()
    {
        Console.WriteLine(employeeID + " " + department);
    }
}
