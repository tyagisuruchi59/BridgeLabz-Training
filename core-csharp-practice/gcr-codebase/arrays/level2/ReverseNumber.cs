using System;

class ReverseNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        if (!int.TryParse(Console.ReadLine(), out int number) || number <= 0)
        {
            Console.Error.WriteLine("Invalid number.");
            return;
        }

        string input = number.ToString();
        int count = input.Length;

        int[] digits = new int[count];
        for (int i = 0; i < count; i++)
        {
            digits[i] = number % 10;
            number /= 10;
        }

        Console.Write("Reversed Number: ");
        for (int i = 0; i < digits.Length; i++)
            Console.Write(digits[i]);
    }
}
