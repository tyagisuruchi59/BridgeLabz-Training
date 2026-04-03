using System;

class EmployeeBonus
{
    static void Main(string[] args)
    {
        Console.Write("Enter salary: ");
        double salary = double.Parse(Console.ReadLine());

        Console.Write("Enter years of service: ");
        int years = int.Parse(Console.ReadLine());

        if (years > 5)
        {
            double bonus = salary * 0.05;
            Console.WriteLine($"Bonus amount is {bonus}");
        }
        else
        {
            Console.WriteLine("No bonus applicable");
        }
    }
}
