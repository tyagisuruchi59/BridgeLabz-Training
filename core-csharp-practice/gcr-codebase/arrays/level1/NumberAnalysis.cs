using System;

class NumberAnalysis
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];

        // Input values
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.Error.WriteLine("Invalid input.");
                Environment.Exit(1);
            }
        }

        // Analyze numbers
        foreach (int number in numbers)
        {
            if (number > 0)
                Console.WriteLine(number % 2 == 0 ? "Positive Even" : "Positive Odd");
            else if (number < 0)
                Console.WriteLine("Negative");
            else
                Console.WriteLine("Zero");
        }

        // Compare first and last element
        if (numbers[0] == numbers[^1])
            Console.WriteLine("First and last elements are equal.");
        else if (numbers[0] > numbers[^1])
            Console.WriteLine("First element is greater.");
        else
            Console.WriteLine("Last element is greater.");
    }
}
