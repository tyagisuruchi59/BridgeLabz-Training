using System;

class FactorsOfNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.Error.WriteLine("Invalid input.");
            Environment.Exit(1);
        }

        int maxSize = 10;
        int[] factors = new int[maxSize];
        int index = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                if (index == maxSize)
                {
                    maxSize *= 2;
                    int[] temp = new int[maxSize];
                    Array.Copy(factors, temp, factors.Length);
                    factors = temp;
                }
                factors[index++] = i;
            }
        }

        Console.WriteLine("Factors:");
        for (int i = 0; i < index; i++)
            Console.Write(factors[i] + " ");
    }
}
