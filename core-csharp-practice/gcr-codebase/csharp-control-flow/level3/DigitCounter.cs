using System;

// Class to count number of digits in an integer
class DigitCounter
{
    static void Main(string[] args)
    {
        // Prompt user for input
        Console.Write("Enter a number: ");

        // Read input
        int number = int.Parse(Console.ReadLine());

        // Variable to store count of digits
        int count = 0;

        // Loop until number becomes zero
        while (number != 0)
        {
            // Remove last digit
            number = number / 10;

            // Increase digit count
            count++;
        }

        // Display result
        Console.WriteLine($"Number of digits is {count}");
    }
}
