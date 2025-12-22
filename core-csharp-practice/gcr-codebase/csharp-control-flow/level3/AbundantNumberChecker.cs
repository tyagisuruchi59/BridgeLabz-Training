using System;

// Class to check Abundant Number
class AbundantNumberChecker
{
    static void Main(string[] args)
    {
        // Prompt user for input
        Console.Write("Enter a number: ");

        // Read input number
        int number = int.Parse(Console.ReadLine());

        // Variable to store sum of divisors
        int sum = 0;

        // Loop to find divisors
        for (int i = 1; i < number; i++)
        {
            // Check if i is a divisor
            if (number % i == 0)
            {
                sum += i;
            }
        }

        // Check abundant condition
        if (sum > number)
        {
            Console.WriteLine("Abundant Number");
        }
        else
        {
            Console.WriteLine("Not an Abundant Number");
        }
    }
}
