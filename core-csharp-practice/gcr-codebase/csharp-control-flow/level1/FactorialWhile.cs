using System;

class FactorialWhile
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            int factorial = 1;
            int i = 1;

            while (i <= number)
            {
                factorial *= i;
                i++;
            }

            Console.WriteLine($"Factorial of {number} is {factorial}");
        }
        else
        {
            Console.WriteLine("Enter a positive number");
        }
    }
}
