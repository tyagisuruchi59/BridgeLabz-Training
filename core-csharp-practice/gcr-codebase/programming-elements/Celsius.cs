using System;

class Celsius
{
    static void Main(string[] args)
    {
        double celsius = 25;   // fixed temperature

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("Temperature in Fahrenheit = " + fahrenheit);
    }
}
