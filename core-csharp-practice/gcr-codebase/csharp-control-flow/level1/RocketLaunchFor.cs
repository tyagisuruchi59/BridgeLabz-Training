using System;

class RocketLaunchFor
{
    static void Main(string[] args)
    {
        // Input value
        Console.Write("Enter countdown start value: ");
        int counter = int.Parse(Console.ReadLine());

        // Countdown using for loop
        for (int i = counter; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
}
