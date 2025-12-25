using System;

// Utility class for temperature, weight, and volume conversions
class UnitConverterUniversal
{
    // Convert Fahrenheit to Celsius
    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    // Convert Celsius to Fahrenheit
    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // Convert pounds to kilograms
    public static double ConvertPoundsToKilograms(double pounds)
    {
        double poundsToKgFactor = 0.453592;
        return pounds * poundsToKgFactor;
    }

    // Convert kilograms to pounds
    public static double ConvertKilogramsToPounds(double kilograms)
    {
        double kgToPoundsFactor = 2.20462;
        return kilograms * kgToPoundsFactor;
    }

    // Convert gallons to liters
    public static double ConvertGallonsToLiters(double gallons)
    {
        double gallonsToLitersFactor = 3.78541;
        return gallons * gallonsToLitersFactor;
    }

    // Convert liters to gallons
    public static double ConvertLitersToGallons(double liters)
    {
        double litersToGallonsFactor = 0.264172;
        return liters * litersToGallonsFactor;
    }

    static void Main()
    {
        Console.WriteLine("98.6 F to Celsius: " + ConvertFahrenheitToCelsius(98.6));
        Console.WriteLine("37 C to Fahrenheit: " + ConvertCelsiusToFahrenheit(37));
        Console.WriteLine("10 Pounds to Kg: " + ConvertPoundsToKilograms(10));
        Console.WriteLine("5 Kg to Pounds: " + ConvertKilogramsToPounds(5));
        Console.WriteLine("2 Gallons to Liters: " + ConvertGallonsToLiters(2));
        Console.WriteLine("5 Liters to Gallons: " + ConvertLitersToGallons(5));
    }
}
