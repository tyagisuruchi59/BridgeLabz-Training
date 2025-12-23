using System;

class DigitFrequency
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int number) || number < 0)
        {
            Console.Error.WriteLine("Invalid number.");
            return;
        }

        int[] digits = new int[input.Length];
        int[] frequency = new int[10];

        for (int i = 0; i < digits.Length; i++)
        {
            digits[i] = number % 10;
            number /= 10;
        }

        for (int i = 0; i < digits.Length; i++)
            frequency[digits[i]]++;

        for (int i = 0; i < frequency.Length; i++)
            Console.WriteLine($"Digit {i} occurs {frequency[i]} times");
    }
}
