using System;

class NumberTypeCheck
{
    static void Main(string[] args)
    {
        // Input number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Check number type
        if (number > 0)
            Console.WriteLine("Positive");
        else if (number < 0)
            Console.WriteLine("Negative");
        else
            Console.WriteLine("Zero");
    }
}
