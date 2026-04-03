using System;

class LargestNumber
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

        // Check largest
        Console.WriteLine($"Is the first number the largest? {number1 > number2 && number1 > number3}");
        Console.WriteLine($"Is the second number the largest? {number2 > number1 && number2 > number3}");
        Console.WriteLine($"Is the third number the largest? {number3 > number1 && number3 > number2}");
    }
}
