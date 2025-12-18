using System;

class Power
{
    static void Main(string[] args)
    {
        double baseValue = 4;    // fixed base
        double exponent = 2;     // fixed exponent

        double result = Math.Pow(baseValue, exponent);

        Console.WriteLine("Result: " + result);
    }
}
