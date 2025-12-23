// Program Name : ZaraEmployeeBonus
// Purpose      : Calculate bonus, new salary and total payout for employees
// Company      : Zara

using System;

class ZaraEmployeeBonus
{
    static void Main(string[] args)
    {
        // Variable to store total number of employees
        int totalEmployees = 10;

        // Arrays to store salary and years of service
        double[] salaries = new double[totalEmployees];
        double[] yearsOfService = new double[totalEmployees];

        // Arrays to store bonus amount and new salary
        double[] bonusAmounts = new double[totalEmployees];
        double[] newSalaries = new double[totalEmployees];

        // Variables to store totals
        double totalBonus = 0.0;
        double totalOldSalary = 0.0;
        double totalNewSalary = 0.0;

        // Loop to take input from user
        for (int index = 0; index < salaries.Length; index++)
        {
            Console.Write($"Enter salary of employee {index + 1}: ");
            if (!double.TryParse(Console.ReadLine(), out double salary) || salary <= 0)
            {
                Console.Error.WriteLine("Invalid salary entered. Please enter again.");
                index--;
                continue;
            }

            Console.Write($"Enter years of service of employee {index + 1}: ");
            if (!double.TryParse(Console.ReadLine(), out double service) || service < 0)
            {
                Console.Error.WriteLine("Invalid years of service. Please enter again.");
                index--;
                continue;
            }

            // Store valid input in arrays
            salaries[index] = salary;
            yearsOfService[index] = service;
        }

        // Loop to calculate bonus and new salary
        for (int index = 0; index < salaries.Length; index++)
        {
            // Determine bonus percentage
            double bonusPercentage = yearsOfService[index] > 5 ? 0.05 : 0.02;

            // Calculate bonus
            bonusAmounts[index] = salaries[index] * bonusPercentage;

            // Calculate new salary
            newSalaries[index] = salaries[index] + bonusAmounts[index];

            // Update totals
            totalBonus += bonusAmounts[index];
            totalOldSalary += salaries[index];
            totalNewSalary += newSalaries[index];
        }

        // Display final results
        Console.WriteLine("\n----- Zara Bonus Summary -----");
        Console.WriteLine($"Total Old Salary  : {totalOldSalary}");
        Console.WriteLine($"Total Bonus Paid  : {totalBonus}");
        Console.WriteLine($"Total New Salary  : {totalNewSalary}");
    }
}
