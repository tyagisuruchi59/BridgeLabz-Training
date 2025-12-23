using System;

class OddEvenSeparation
{
    static void Main(string[] args)
    {
        Console.Write("Enter a natural number: ");
        if (!int.TryParse(Console.ReadLine(), out int number) || number <= 0)
        {
            Console.Error.WriteLine("Invalid natural number.");
            Environment.Exit(1);
        }

        int[] even = new int[number / 2 + 1];
        int[] odd = new int[number / 2 + 1];
        int evenIndex = 0, oddIndex = 0;

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
                even[evenIndex++] = i;
            else
                odd[oddIndex++] = i;
        }

        Console.WriteLine("Even Numbers:");
        for (int i = 0; i < evenIndex; i++)
            Console.Write(even[i] + " ");

        Console.WriteLine("\nOdd Numbers:");
        for (int i = 0; i < oddIndex; i++)
            Console.Write(odd[i] + " ");
    }
}
