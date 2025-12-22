using System;

class Divisible
{
    static void Main(string[] args)
    {
        // Ask user for input
        Console.Write("Enter a number: ");

        // Read input number
        int number = int.Parse(Console.ReadLine());

        // Check divisibility
        bool isDivisible = (number % 5 == 0);

        // Display result
        Console.WriteLine($"Is the number {number} divisible by 5? {isDivisible}");
    }
}
