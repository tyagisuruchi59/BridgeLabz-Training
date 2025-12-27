using System;

class BasicCalculator
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Choose operation: +  -  *  /");
        char op = Console.ReadLine()[0];

        double result = Calculate(a, b, op);
        Console.WriteLine("Result: " + result);
    }

    static double Calculate(double x, double y, char op)
    {
        switch (op)
        {
            case '+': return Add(x, y);
            case '-': return Subtract(x, y);
            case '*': return Multiply(x, y);
            case '/': return Divide(x, y);
            default: return 0;
        }
    }

    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;
    static double Divide(double a, double b) => b != 0 ? a / b : 0;
}
