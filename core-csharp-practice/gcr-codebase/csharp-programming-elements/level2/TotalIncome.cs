using System;

class TotalIncome
{
    static void Main()
    {
        double salary, bonus;

        Console.Write("Enter salary: ");
        salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter bonus: ");
        bonus = Convert.ToDouble(Console.ReadLine());

        double totalIncome = salary + bonus;

        Console.WriteLine(
            $"The salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {totalIncome}"
        );
    }
}
