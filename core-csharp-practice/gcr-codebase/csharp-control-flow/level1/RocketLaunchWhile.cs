using System;

class RocketLaunchWhile
{
    static void Main(string[] args)
    {
        // Input countdown value
        Console.Write("Enter countdown start value: ");
        int counter = int.Parse(Console.ReadLine());

        // Countdown loop
        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;
        }
    }
}
