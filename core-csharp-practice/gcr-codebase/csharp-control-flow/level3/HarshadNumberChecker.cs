using System;

// Class to check Harshad Number
class HarshadNumberChecker
{
    static void Main(string[] args)
    {
        // Prompt user for input
        Console.Write("Enter a number: ");

        // Read input number
        int number = int.Parse(Console.ReadLine());

        // Store original number
        int originalNumber = number;

        // Variable to store sum of digits
        int sum = 0;

        // Loop to calculate sum of digits
        while (number != 0)
        {
            int digit = number % 10;
            sum += digit;
            number = number / 10;
        }

        // Check Harshad condition
        if (originalNumber % sum == 0)
        {
            Console.WriteLine("Harshad Number");
        }
        else
        {
            Console.WriteLine("Not a Harshad Number");
        }
    }
}
