using System;
using System.Collections.Generic;

interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string location);
}

abstract class Vehicle
{
    protected string vehicleId;
    protected string driverName;
    protected double ratePerKm;

    protected Vehicle(string id, string driver, double rate)
    {
        vehicleId = id;
        driverName = driver;
        ratePerKm = rate;
    }

    public abstract double CalculateFare(double distance);

    public void GetVehicleDetails()
    {
        Console.WriteLine($"Vehicle:{vehicleId}, Driver:{driverName}");
    }
}

class Auto : Vehicle
{
    public Auto(string id, string driver, double rate)
        : base(id, driver, rate) { }

    public override double CalculateFare(double distance)
    {
        return distance * ratePerKm;
    }
}

class Program
{
    static void Main()
    {
        Vehicle v = new Auto("AUTO1", "Suresh", 12);
        Console.WriteLine(v.CalculateFare(10));
    }
}
