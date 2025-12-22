using System;

// Class to check Leap Year using multiple if-else conditions
class LeapYearChecker
{
    static void Main(string[] args)
    {
        // Prompt user for year
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        // Check Gregorian calendar condition
        if (year >= 1582)
        {
            if (year % 400 == 0)
                Console.WriteLine("The year is a Leap Year");
            else if (year % 100 == 0)
                Console.WriteLine("The year is not a Leap Year");
            else if (year % 4 == 0)
                Console.WriteLine("The year is a Leap Year");
            else
                Console.WriteLine("The year is not a Leap Year");
        }
        else
        {
            Console.WriteLine("Year must be 1582 or later");
        }
    }
}
