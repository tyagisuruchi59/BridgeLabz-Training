using System;

class PurchasePrice
{
    static void Main()
    {
        double unitPrice;
        int quantity;
        double totalPrice;

        Console.Write("Enter unit price: ");
        unitPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter quantity: ");
        quantity = Convert.ToInt32(Console.ReadLine());

        totalPrice = unitPrice * quantity;

        Console.WriteLine(
            "The total purchase price is INR " + totalPrice +
            " if the quantity " + quantity +
            " and unit price is INR " + unitPrice
        );
    }
}
