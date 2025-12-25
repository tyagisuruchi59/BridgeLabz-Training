using System;

// Utility class for additional unit conversions
class UnitConverterAdvance
{
    // Convert yards to feet
    public static double ConvertYardsToFeet(double yards)
    {
        double yardsToFeetFactor = 3;
        return yards * yardsToFeetFactor;
    }

    // Convert feet to yards
    public static double ConvertFeetToYards(double feet)
    {
        double feetToYardsFactor = 0.333333;
        return feet * feetToYardsFactor;
    }

    // Convert meters to inches
    public static double ConvertMetersToInches(double meters)
    {
        double metersToInchesFactor = 39.3701;
        return meters * metersToInchesFactor;
    }

    // Convert inches to meters
    public static double ConvertInchesToMeters(double inches)
    {
        double inchesToMetersFactor = 0.0254;
        return inches * inchesToMetersFactor;
    }

    // Convert inches to centimeters
    public static double ConvertInchesToCentimeters(double inches)
    {
        double inchesToCmFactor = 2.54;
        return inches * inchesToCmFactor;
    }

    static void Main()
    {
        Console.WriteLine("5 Yards to Feet: " + ConvertYardsToFeet(5));
        Console.WriteLine("6 Feet to Yards: " + ConvertFeetToYards(6));
        Console.WriteLine("2 Meters to Inches: " + ConvertMetersToInches(2));
        Console.WriteLine("10 Inches to Meters: " + ConvertInchesToMeters(10));
        Console.WriteLine("8 Inches to Cm: " + ConvertInchesToCentimeters(8));
    }
}
