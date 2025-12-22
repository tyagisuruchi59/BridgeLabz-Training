using System;

// Class to find Day of the Week
class DayOfWeekCalculator
{
    static void Main(string[] args)
    {
        // Read month, day, and year from command line
        int m = int.Parse(args[0]);
        int d = int.Parse(args[1]);
        int y = int.Parse(args[2]);

        // Apply given formula
        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + (31 * m0) / 12) % 7;

        // Display day of the week
        Console.WriteLine(d0);
    }
}
