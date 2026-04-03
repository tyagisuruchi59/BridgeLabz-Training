class Vehicle
{
    private string ownerName;
    private string vehicleType;
    private static double registrationFee = 5000;

    public Vehicle(string ownerName, string vehicleType)
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }

    public void DisplayVehicleDetails()
    {
        Console.WriteLine($"{ownerName} - {vehicleType}");
    }

    public static void UpdateRegistrationFee(double fee)
    {
        registrationFee = fee;
    }
}
