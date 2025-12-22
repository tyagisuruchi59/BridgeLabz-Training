using System;

class SumUntilNegative
{
    static void Main(string[] args)
    {
        double total = 0.0;

        while (true)
        {
            Console.Write("Enter a number: ");
            double number = double.Parse(Console.ReadLine());

            if (number <= 0)
                break;

            total += number;
        }

        Console.WriteLine($"Total sum is {total}");
    }
}
