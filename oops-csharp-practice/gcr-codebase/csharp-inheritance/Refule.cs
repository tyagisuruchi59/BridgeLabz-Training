interface Refuelable
{
    void Refuel();
}

class Vehicle
{
    public int MaxSpeed;
    public string Model;
}

class ElectricVehicle : Vehicle
{
    public void Charge()
    {
        Console.WriteLine("Charging...");
    }
}

class PetrolVehicle : Vehicle, Refuelable
{
    public void Refuel()
    {
        Console.WriteLine("Refueling petrol...");
    }
}
