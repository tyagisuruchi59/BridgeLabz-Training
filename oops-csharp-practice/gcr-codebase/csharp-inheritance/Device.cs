class Device
{
    public int DeviceId;
    public string Status;
}

class Thermostat : Device
{
    public int TemperatureSetting;

    public void DisplayStatus()
    {
        Console.WriteLine($"Temp: {TemperatureSetting}, Status: {Status}");
    }
}
