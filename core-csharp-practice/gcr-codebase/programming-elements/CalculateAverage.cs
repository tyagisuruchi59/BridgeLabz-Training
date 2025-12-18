using System;

class CalculateAverage
{
    static void Main(string[] args)
    {
        double baseValue = 2;      // fixed base
        double exponent = 3;       // fixed exponent

        double result = Math.Pow(baseValue, exponent);

        Console.WriteLine("Result: " + result);
    }
}
