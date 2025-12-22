using System;

// Class to find factors
class FactorsOfNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
                Console.WriteLine(i);
        }
    }
}
