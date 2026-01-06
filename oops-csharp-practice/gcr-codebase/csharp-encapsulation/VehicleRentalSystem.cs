using System;
using System.Collections.Generic;

interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

abstract class Vehicle
{
    protected string vehicleNumber;
    protected double rentalRate;

    protected Vehicle(string number, double rate)
    {
        vehicleNumber = number;
        rentalRate = rate;
    }

    public abstract double CalculateRentalCost(int days);
}

class Car : Vehicle, IInsurable
{
    public Car(string number, double rate) : base(number, rate) { }

    public override double CalculateRentalCost(int days) => days * rentalRate;
    public double CalculateInsurance() => 500;
    public string GetInsuranceDetails() => "Car Insurance";
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("CAR101", 1000)
        };

        foreach (Vehicle v in vehicles)
        {
            Console.WriteLine($"Rental: {v.CalculateRentalCost(3)}");
        }
    }
}
