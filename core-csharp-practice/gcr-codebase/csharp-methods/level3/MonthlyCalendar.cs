using System;

// Class name clearly indicates purpose
class MonthlyCalendar
{
    // Method to check Leap Year
    public static bool IsLeapYear(int year)
    {
        if (year < 1582)
            return false;

        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    // Method to get month name
    public static string GetMonthName(int month)
    {
        string[] months =
        {
            "January", "February", "March", "April",
            "May", "June", "July", "August",
            "September", "October", "November", "December"
        };

        return months[month - 1];
    }

    // Method to get number of days in a month
    public static int GetDaysInMonth(int month, int year)
    {
        int[] daysInMonth =
        {
            31, 28, 31, 30, 31, 30,
            31, 31, 30, 31, 30, 31
        };

        if (month == 2 && IsLeapYear(year))
            return 29;

        return daysInMonth[month - 1];
    }

    // Method to get first day of the month (0 = Sunday)
    public static int GetFirstDayOfMonth(int month, int year)
    {
        int d = 1;
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (d + x + (31 * m0) / 12) % 7;

        return d0;
    }

    // Method to display calendar
    public static void DisplayCalendar(int month, int year)
    {
        Console.WriteLine("\n\t" + GetMonthName(month) + " " + year);
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        int firstDay = GetFirstDayOfMonth(month, year);
        int daysInMonth = GetDaysInMonth(month, year);

        // Indentation for first day
        for (int i = 0; i < firstDay; i++)
        {
            Console.Write("    ");
        }

        // Print days
        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write("{0,3} ", day);

            if ((day + firstDay) % 7 == 0)
                Console.WriteLine();
        }

        Console.WriteLine();
    }

    // Main Method
    static void Main(string[] args)
    {
        Console.Write("Enter Month (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        DisplayCalendar(month, year);
    }
}
