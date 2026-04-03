using System;

class SmallestNumberCheck
{
    static void Main(string[] args)
    {
        // Input numbers
        Console.Write("Enter first number: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int number2 = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int number3 = int.Parse(Console.ReadLine());

        // Check condition
        bool isSmallest = (number1 < number2 && number1 < number3);

        // Output
        Console.WriteLine($"Is the first number the smallest? {isSmallest}");
    }
}
