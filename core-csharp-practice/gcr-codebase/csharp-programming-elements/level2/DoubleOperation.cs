using System;

class QuotientRemainder
{
    static void Main()
    {
        int number1, number2;

        Console.Write(Enter first number );
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write(Enter second number );
        number2 = Convert.ToInt32(Console.ReadLine());

        int quotient = number1  number2;
        int remainder = number1 % number2;

        Console.WriteLine(
            $The Quotient is {quotient} and Remainder is {remainder} of two numbers {number1} and {number2}
        );
    }
}
