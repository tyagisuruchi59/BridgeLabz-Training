using System;

class MaximumOfThree
{
    static void Main()
    {
        int a = ReadNumber("Enter first number: ");
        int b = ReadNumber("Enter second number: ");
        int c = ReadNumber("Enter third number: ");

        int max = FindMax(a, b, c);
        Console.WriteLine("Maximum number is: " + max);
    }

    static int ReadNumber(string message)
    {
        Console.Write(message);
        return int.Parse(Console.ReadLine());
    }

    static int FindMax(int x, int y, int z)
    {
        return (x > y && x > z) ? x : (y > z ? y : z);
    }
}
