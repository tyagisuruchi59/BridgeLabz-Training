using System;

class FahrenheitToCelsius
{
    static void Main()
    {
        double fahrenheit;

        Console.Write("Enter temperature in Fahrenheit: ");
        fahrenheit = Convert.ToDouble(Console.ReadLine());

        double celsiusResult = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine(
            $"The {fahrenheit} Fahrenheit is {celsiusResult} Celsius"
        );
    }
}
