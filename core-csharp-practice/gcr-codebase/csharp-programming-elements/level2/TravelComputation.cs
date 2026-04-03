using System;

class TravelComputation
{
    static void Main()
    {
        string name = "Eric";
        string fromCity = "Chennai";
        string viaCity = "Vellore";
        string toCity = "Bangalore";

        double distanceFromToVia = 156.6;
        double distanceViaToFinalCity = 211.8;

        int timeFromToVia = 4 * 60 + 4;
        int timeViaToFinalCity = 4 * 60 + 25;

        double totalDistance = distanceFromToVia + distanceViaToFinalCity;
        int totalTime = timeFromToVia + timeViaToFinalCity;

        Console.WriteLine(
            $"The Total Distance travelled by {name} from {fromCity} to {toCity} via {viaCity} is {totalDistance} km and the Total Time taken is {totalTime} minutes"
        );
    }
}
