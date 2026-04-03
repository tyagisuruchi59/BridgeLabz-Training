using System;

class BusRouteDistanceTracker
{
    static void Main()
    {
        int totalDistance = 0;
        string choice = "no";

        while (choice != "yes")
        {
            Console.WriteLine("Bus reached next stop. Distance added: 5 km");
            totalDistance += 5;

            Console.WriteLine("Do you want to get off at this stop? (yes/no)");
            choice = Console.ReadLine().ToLower();
        }

        Console.WriteLine("You got off the bus.");
        Console.WriteLine("Total distance travelled: " + totalDistance + " km");
    }
}
