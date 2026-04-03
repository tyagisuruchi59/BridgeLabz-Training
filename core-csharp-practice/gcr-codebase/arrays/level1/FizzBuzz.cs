using System;

class FizzBuzz
{
    static void Main(string[] args)
    {
        Console.Write("Enter a positive number: ");
        if (!int.TryParse(Console.ReadLine(), out int number) || number <= 0)
        {
            Console.Error.WriteLine("Invalid input.");
            Environment.Exit(1);
        }

        string[] result = new string[number + 1];

        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                result[i] = "FizzBuzz";
            else if (i % 3 == 0)
                result[i] = "Fizz";
            else if (i % 5 == 0)
                result[i] = "Buzz";
            else
                result[i] = i.ToString();
        }

        for (int i = 1; i <= number; i++)
            Console.WriteLine($"Position {i} = {result[i]}");
    }
}
