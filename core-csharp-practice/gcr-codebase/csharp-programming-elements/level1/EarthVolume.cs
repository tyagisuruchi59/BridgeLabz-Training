using System;

class EarthVolume
{
    static void Main()
    {
        double radiusKm = 6378;
        double pi = Math.PI;

        double volumeKm3 = (4.0 / 3.0) * pi * radiusKm * radiusKm * radiusKm;

        double kmToMiles = 0.621371;
        double volumeMiles3 = volumeKm3 * kmToMiles * kmToMiles * kmToMiles;

        Console.WriteLine(
            "The volume of earth in cubic kilometers is " + volumeKm3 +
            " and cubic miles is " + volumeMiles3
        );
    }
}
