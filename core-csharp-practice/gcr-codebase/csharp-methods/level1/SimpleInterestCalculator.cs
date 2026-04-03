using System;

class SimpleInterestCalculator
{
    // Method to calculate Simple Interest
    public static double CalculateSimpleInterest(double principal, double rate, double time)
    {
        double simpleInterest = (principal * rate * time) / 100;
        return simpleInterest;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter Principal: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time: ");
        double time = Convert.ToDouble(Console.ReadLine());

        double result = CalculateSimpleInterest(principal, rate, time);

        Console.WriteLine(
            "The Simple Interest is " + result +
            " for Principal " + principal +
            ", Rate of Interest " + rate +
            " and Time " + time
        );
    }
}
