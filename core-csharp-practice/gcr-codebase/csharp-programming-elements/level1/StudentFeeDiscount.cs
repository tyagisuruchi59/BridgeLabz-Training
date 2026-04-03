using System;

class StudentFeeDiscount
{
    static void Main()
    {
        double fee;
        double discountPercent;
        double discount;
        double finalFee;

        Console.Write("Enter the course fee: ");
        fee = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the discount percentage: ");
        discountPercent = Convert.ToDouble(Console.ReadLine());

        discount = (fee * discountPercent) / 100;
        finalFee = fee - discount;

        Console.WriteLine(
            "The discount amount is INR " + discount +
            " and final discounted fee is INR " + finalFee
        );
    }
}
