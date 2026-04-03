using System;

class SwapNumbers
{
    static void Main()
    {
        int number1, number2, temp;

        Console.Write("Enter first number: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        temp = number1;
        number1 = number2;
        number2 = temp;

        Console.WriteLine(
            $"The swapped numbers are {number1} and {number2}"
        );
    }
}
