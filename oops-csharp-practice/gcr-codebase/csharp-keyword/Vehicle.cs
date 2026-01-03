using System;

class Vehicle
{
    public static double RegistrationFee = 1500;

    public readonly string RegistrationNumber;
    public string OwnerName;
    public string VehicleType;

    public Vehicle(string ownerName, string vehicleType, string regNumber)
    {
        this.OwnerName = ownerName;
        this.VehicleType = vehicleType;
        this.RegistrationNumber = regNumber;
    }

    public static void UpdateRegistrationFee(double fee)
    {
        RegistrationFee = fee;
    }

    public void DisplayVehicle(object obj)
    {
        if (obj is Vehicle)
        {
            Console.WriteLine($"{OwnerName} - {VehicleType} ({RegistrationNumber})");
        }
    }
}

class Program
{
    static void Main()
    {
        Vehicle v = new Vehicle("Suru", "Bike", "UP85AB1234");
        v.DisplayVehicle(v);
    }
}
