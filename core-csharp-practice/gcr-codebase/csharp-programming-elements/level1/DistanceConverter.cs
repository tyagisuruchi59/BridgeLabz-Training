using System;

class DistanceConverter
{
    static void Main()
    {
        double kilometers = 10.8;
        double milesPerKm = 1.6;

        double miles = kilometers * milesPerKm;

        Console.WriteLine("The distance " + kilometers + " km in miles is " + miles);
    }
}
