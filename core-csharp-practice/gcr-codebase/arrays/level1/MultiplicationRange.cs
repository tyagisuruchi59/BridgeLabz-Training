using System;

class MultiplicationRange
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.Error.WriteLine("Invalid input.");
            Environment.Exit(1);
        }

        int[] results = new int[4];
        int index = 0;

        for (int i = 6; i <= 9; i++)
        {
            results[index++] = number * i;
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }
}
