using System;

// Utility class for basic length unit conversions
class UnitConverter
{
    // Convert kilometers to miles
    public static double ConvertKmToMiles(double kilometers)
    {
        double kmToMilesFactor = 0.621371;
        return kilometers * kmToMilesFactor;
    }

    // Convert miles to kilometers
    public static double ConvertMilesToKm(double miles)
    {
        double milesToKmFactor = 1.60934;
        return miles * milesToKmFactor;
    }

    // Convert meters to feet
    public static double ConvertMetersToFeet(double meters)
    {
        double metersToFeetFactor = 3.28084;
        return meters * metersToFeetFactor;
    }

    // Convert feet to meters
    public static double ConvertFeetToMeters(double feet)
    {
        double feetToMetersFactor = 0.3048;
        return feet * feetToMetersFactor;
    }

    static void Main()
    {
        Console.WriteLine("10 Km to Miles: " + ConvertKmToMiles(10));
        Console.WriteLine("5 Miles to Km: " + ConvertMilesToKm(5));
        Console.WriteLine("3 Meters to Feet: " + ConvertMetersToFeet(3));
        Console.WriteLine("10 Feet to Meters: " + ConvertFeetToMeters(10));
    }
}
