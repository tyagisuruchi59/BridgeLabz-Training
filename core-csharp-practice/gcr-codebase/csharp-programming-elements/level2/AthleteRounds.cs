using System;

class AthleteRounds
{
    static void Main()
    {
        double side1, side2, side3;

        Console.Write("Enter side1: ");
        side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side2: ");
        side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side3: ");
        side3 = Convert.ToDouble(Console.ReadLine());

        double perimeter = side1 + side2 + side3;
        double rounds = 5000 / perimeter;

        Console.WriteLine(
            $"The total number of rounds the athlete will run is {rounds}"
        );
    }
}
