using System;

class ChocolateDistribution
{
    static void Main()
    {
        int numberOfChocolates, numberOfChildren;

        Console.Write("Enter chocolates: ");
        numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter children: ");
        numberOfChildren = Convert.ToInt32(Console.ReadLine());

        int eachGets = numberOfChocolates / numberOfChildren;
        int remaining = numberOfChocolates % numberOfChildren;

        Console.WriteLine(
            $"The number of chocolates each child gets is {eachGets} and the number of remaining chocolates is {remaining}"
        );
    }
}
