using System;

class SimpleInterest
{
    static void Main()
    {
        double principal, rate, time;

        Console.Write("Enter principal: ");
        principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter rate: ");
        rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time: ");
        time = Convert.ToDouble(Console.ReadLine());

        double interest = (principal * rate * time) / 100;

        Console.WriteLine(
            $"The Simple Interest is {interest} for Principal {principal}, Rate of Interest {rate} and Time {time}"
        );
    }
}
