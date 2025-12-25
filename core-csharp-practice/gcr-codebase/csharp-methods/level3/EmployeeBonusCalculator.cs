using System;

// Class name clearly indicates purpose
class EmployeeBonusCalculator
{
    private const int EmployeeCount = 10;

    // Method to generate salary and years of service
    // Column 0 → Old Salary
    // Column 1 → Years of Service
    public static double[,] GenerateEmployeeData()
    {
        double[,] data = new double[EmployeeCount, 2];
        Random random = new Random();

        for (int i = 0; i < EmployeeCount; i++)
        {
            data[i, 0] = random.Next(10000, 100000); // 5-digit salary
            data[i, 1] = random.Next(1, 11);         // Years of service (1–10)
        }

        return data;
    }

    // Method to calculate bonus and new salary
    // Column 0 → Old Salary
    // Column 1 → Bonus
    // Column 2 → New Salary
    public static double[,] CalculateBonus(double[,] employeeData)
    {
        double[,] salaryDetails = new double[EmployeeCount, 3];

        for (int i = 0; i < EmployeeCount; i++)
        {
            double salary = employeeData[i, 0];
            double years = employeeData[i, 1];

            double bonusRate = (years > 5) ? 0.05 : 0.02;
            double bonus = salary * bonusRate;
            double newSalary = salary + bonus;

            salaryDetails[i, 0] = salary;
            salaryDetails[i, 1] = bonus;
            salaryDetails[i, 2] = newSalary;
        }

        return salaryDetails;
    }

    // Method to display results in tabular format
    public static void DisplayResults(double[,] employeeData, double[,] salaryDetails)
    {
        double totalOldSalary = 0;
        double totalBonus = 0;
        double totalNewSalary = 0;

        Console.WriteLine("\nEmp\tOldSalary\tYears\tBonus\t\tNewSalary");

        for (int i = 0; i < EmployeeCount; i++)
        {
            double oldSalary = salaryDetails[i, 0];
            double bonus = salaryDetails[i, 1];
            double newSalary = salaryDetails[i, 2];
            double years = employeeData[i, 1];

            totalOldSalary += oldSalary;
            totalBonus += bonus;
            totalNewSalary += newSalary;

            Console.WriteLine(
                (i + 1) + "\t" +
                oldSalary + "\t\t" +
                years + "\t" +
                Math.Round(bonus, 2) + "\t\t" +
                Math.Round(newSalary, 2)
            );
        }

        Console.WriteLine("\n-----------------------------------------------");
        Console.WriteLine("Total Old Salary : " + Math.Round(totalOldSalary, 2));
        Console.WriteLine("Total Bonus      : " + Math.Round(totalBonus, 2));
        Console.WriteLine("Total New Salary : " + Math.Round(totalNewSalary, 2));
    }

    // Main Method
    static void Main(string[] args)
    {
        double[,] employeeData = GenerateEmployeeData();
        double[,] salaryDetails = CalculateBonus(employeeData);
        DisplayResults(employeeData, salaryDetails);
    }
}
