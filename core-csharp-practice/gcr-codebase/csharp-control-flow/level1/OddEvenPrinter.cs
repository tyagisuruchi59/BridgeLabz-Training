using System;

class OddEvenPrinter
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"{i} is {(i % 2 == 0 ? "Even" : "Odd")}");
            }
        }
        else
        {
            Console.WriteLine("Not a natural number");
        }
    }
}
