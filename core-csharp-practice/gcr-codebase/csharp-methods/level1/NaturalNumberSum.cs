using System;

class NaturalNumberSum
{
    // Method to calculate sum
    public static int CalculateSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = CalculateSum(n);

        Console.WriteLine("Sum of natural numbers: " + result);
    }
}
