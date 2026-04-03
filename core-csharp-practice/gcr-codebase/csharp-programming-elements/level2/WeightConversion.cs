using System;

class WeightConversion
{
    static void Main()
    {
        double pounds;

        Console.Write(Enter weight in pounds );
        pounds = Convert.ToDouble(Console.ReadLine());

        double kilograms = pounds  2.2;

        Console.WriteLine(
            $The weight of the person in pounds is {pounds} and in kg is {kilograms}
        );
    }
}
