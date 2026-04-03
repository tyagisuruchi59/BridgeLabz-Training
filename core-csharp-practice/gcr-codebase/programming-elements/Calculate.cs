using System;

class Calculate
{
    static void Main(string[] args)
    {
        double p = 1000;   // fixed Principal
        double r = 5;      // fixed Rate of Interest
        double t = 2;      // fixed Time (years)

        double si = (p * r * t) / 100;

        Console.WriteLine("Simple Interest = " + si);
    }
}

