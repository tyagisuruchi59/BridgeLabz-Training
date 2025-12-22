using System;

class SumUntilZero
{
    static void Main(string[] args)
    {
        double total = 0.0;
        double inputValue;

        // Loop until user enters zero
        while (true)
        {
            Console.Write("Enter a number (0 to stop): ");
            inputValue = double.Parse(Console.ReadLine());

            if (inputValue == 0)
                break;

            total += inputValue;
        }

        Console.WriteLine($"Total sum is {total}");
    }
}
