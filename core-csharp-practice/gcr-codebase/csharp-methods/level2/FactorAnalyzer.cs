using System;

class FactorAnalyzer
{
    public static int[] FindFactors(int number)
    {
        int count = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                count++;
        }

        int[] factors = new int[count];
        int index = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                factors[index++] = i;
        }

        return factors;
    }

    public static int FindSum(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
            sum += factor;
        return sum;
    }

    public static int FindProduct(int[] factors)
    {
        int product = 1;
        foreach (int factor in factors)
            product *= factor;
        return product;
    }

    public static double FindSumOfSquares(int[] factors)
    {
        double sum = 0;
        foreach (int factor in factors)
            sum += Math.Pow(factor, 2);
        return sum;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] factors = FindFactors(number);

        Console.WriteLine("Factors:");
        foreach (int f in factors)
            Console.Write(f + " ");

        Console.WriteLine("\nSum: " + FindSum(factors));
        Console.WriteLine("Product: " + FindProduct(factors));
        Console.WriteLine("Sum of Squares: " + FindSumOfSquares(factors));
    }
}
