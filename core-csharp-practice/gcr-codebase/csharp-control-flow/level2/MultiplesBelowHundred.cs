using System;

// Class to find multiples below 100
class MultiplesBelowHundred
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 100; i >= 1; i--)
        {
            if (i % number == 0)
                Console.WriteLine(i);
        }
    }
}
