using System;

// Class name clearly indicates purpose
class FactorNumberAnalyzer
{
    // Method to find factors of a number
    public static int[] FindFactors(int number)
    {
        int count = 0;

        // First loop to count factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                count++;
        }

        int[] factors = new int[count];
        int index = 0;

        // Second loop to store factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                factors[index++] = i;
        }

        return factors;
    }

    // Method to find greatest factor
    public static int FindGreatestFactor(int[] factors)
    {
        int greatest = factors[0];

        foreach (int factor in factors)
        {
            if (factor > greatest)
                greatest = factor;
        }

        return greatest;
    }

    // Method to find sum of factors
    public static int FindSumOfFactors(int[] factors)
    {
        int sum = 0;

        foreach (int factor in factors)
            sum += factor;

        return sum;
    }

    // Method to find product of factors
    public static long FindProductOfFactors(int[] factors)
    {
        long product = 1;

        foreach (int factor in factors)
            product *= factor;

        return product;
    }

    // Method to find product of cube of factors
    public static double FindProductOfCubeOfFactors(int[] factors)
    {
        double product = 1;

        foreach (int factor in factors)
            product *= Math.Pow(factor, 3);

        return product;
    }

    // Method to check Perfect Number
    public static bool IsPerfectNumber(int number, int[] factors)
    {
        int sumOfProperDivisors = 0;

        foreach (int factor in factors)
        {
            if (factor != number)
                sumOfProperDivisors += factor;
        }

        return sumOfProperDivisors == number;
    }

    // Method to check Abundant Number
    public static bool IsAbundantNumber(int number, int[] factors)
    {
        int sumOfProperDivisors = 0;

        foreach (int factor in factors)
        {
            if (factor != number)
                sumOfProperDivisors += factor;
        }

        return sumOfProperDivisors > number;
    }

    // Method to check Deficient Number
    public static bool IsDeficientNumber(int number, int[] factors)
    {
        int sumOfProperDivisors = 0;

        foreach (int factor in factors)
        {
            if (factor != number)
                sumOfProperDivisors += factor;
        }

        return sumOfProperDivisors < number;
    }

    // Method to calculate factorial
    public static int FindFactorial(int digit)
    {
        int factorial = 1;

        for (int i = 1; i <= digit; i++)
            factorial *= i;

        return factorial;
    }

    // Method to check Strong Number
    public static bool IsStrongNumber(int number)
    {
        int temp = number;
        int sum = 0;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += FindFactorial(digit);
            temp /= 10;
        }

        return sum == number;
    }

    // Main Method
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] factors = FindFactors(number);

        Console.WriteLine("\nFactors:");
        foreach (int factor in factors)
        {
            Console.Write(factor + " ");
        }

        Console.WriteLine("\n\nGreatest Factor: " + FindGreatestFactor(factors));
        Console.WriteLine("Sum of Factors: " + FindSumOfFactors(factors));
        Console.WriteLine("Product of Factors: " + FindProductOfFactors(factors));
        Console.WriteLine("Product of Cube of Factors: " + FindProductOfCubeOfFactors(factors));

        Console.WriteLine("\nPerfect Number: " + IsPerfectNumber(number, factors));
        Console.WriteLine("Abundant Number: " + IsAbundantNumber(number, factors));
        Console.WriteLine("Deficient Number: " + IsDeficientNumber(number, factors));
        Console.WriteLine("Strong Number: " + IsStrongNumber(number));
    }
}
