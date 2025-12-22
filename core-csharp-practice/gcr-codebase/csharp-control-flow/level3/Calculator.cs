using System;

// Class to create a simple calculator
class Calculator
{
    static void Main(string[] args)
    {
        // Input first number
        Console.Write("Enter first number: ");
        double first = double.Parse(Console.ReadLine());

        // Input second number
        Console.Write("Enter second number: ");
        double second = double.Parse(Console.ReadLine());

        // Input operator
        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();

        // Perform calculation using switch-case
        switch (op)
        {
            case "+":
                Console.WriteLine($"Result = {first + second}");
                break;

            case "-":
                Console.WriteLine($"Result = {first - second}");
                break;

            case "*":
                Console.WriteLine($"Result = {first * second}");
                break;

            case "/":
                Console.WriteLine($"Result = {first / second}");
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
