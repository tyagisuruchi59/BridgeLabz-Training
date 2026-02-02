using Newtonsoft.Json;

class Car
{
    public string Brand { get; set; }
    public int Year { get; set; }
}

class Program
{
    static void Main()
    {
        Car car = new Car { Brand = "Tesla", Year = 2024 };
        System.Console.WriteLine(JsonConvert.SerializeObject(car, Formatting.Indented));
    }
}
