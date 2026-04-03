using System;

class BasicCalculator
{
    static void Main()
    {
        double number1;
        double number2;

        Console.Write("Enter first number: ");
        number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        number2 = Convert.ToDouble(Console.ReadLine());

        double sum = number1 + number2;
        double difference = number1 - number2;
        double product = number1 * number2;
        double quotient = number1 / number2;

        Console.WriteLine(
            "The addition, subtraction, multiplication and division value of 2 numbers " +
            number1 + " and " + number2 + " is " +
            sum + ", " + difference + ", " + product + ", and " + quotient
        );
    }
}

