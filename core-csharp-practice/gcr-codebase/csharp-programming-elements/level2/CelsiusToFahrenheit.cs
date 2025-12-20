using System;

class CelsiusToFahrenheit
{
    static void Main()
    {
        double celsius;

        Console.Write("Enter temperature in Celsius: ");
        celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheitResult = (celsius * 9 / 5) + 32;

        Console.WriteLine(
            $"The {celsius} Celsius is {fahrenheitResult} Fahrenheit"
        );
    }
}
