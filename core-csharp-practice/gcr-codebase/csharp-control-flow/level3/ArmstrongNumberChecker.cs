using System;

// Class to check whether a number is an Armstrong number
class ArmstrongNumberChecker
{
    static void Main(string[] args)
    {
        // Prompt user for input
        Console.Write("Enter a number: ");

        // Read input number
        int number = int.Parse(Console.ReadLine());

        // Store original number for comparison
        int originalNumber = number;

        // Variable to store sum of cubes of digits
        int sum = 0;

        // Loop to process each digit
        while (number != 0)
        {
            // Get last digit
            int digit = number % 10;

            // Add cube of digit to sum
            sum += digit * digit * digit;

            // Remove last digit
            number = number / 10;
        }

        // Check Armstrong condition
        if (sum == originalNumber)
        {
            Console.WriteLine("It is an Armstrong Number");
        }
        else
        {
            Console.WriteLine("It is not an Armstrong Number");
        }
    }
}
