using System;

class MultiplicationTable
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.Error.WriteLine("Invalid input.");
            Environment.Exit(1);
        }

        int[] table = new int[10];

        for (int i = 1; i <= table.Length; i++)
        {
            table[i - 1] = number * i;
            Console.WriteLine($"{number} * {i} = {table[i - 1]}");
        }
    }
}
