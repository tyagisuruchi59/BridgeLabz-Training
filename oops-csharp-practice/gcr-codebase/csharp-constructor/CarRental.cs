class CarRental
{
    private string customerName;
    private string carModel;
    private int rentalDays;

    public CarRental(string customerName, string carModel, int rentalDays)
    {
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
    }

    private double CalculateCost()
    {
        return rentalDays * 1000;
    }

    public void DisplayBill()
    {
        Console.WriteLine($"Total Cost: {CalculateCost()}");
    }
}
