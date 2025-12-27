using System;

class TimeZoneDemo
{
    static void Main()
    {
        DateTimeOffset gmtTime = DateTimeOffset.UtcNow;

        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(gmtTime, istZone);
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(gmtTime, pstZone);

        Console.WriteLine("GMT Time: " + gmtTime);
        Console.WriteLine("IST Time: " + istTime);
        Console.WriteLine("PST Time: " + pstTime);
    }
}
