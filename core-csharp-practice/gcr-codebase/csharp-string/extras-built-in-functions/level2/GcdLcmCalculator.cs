using System;

class GcdLcmCalculator
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        int gcd = FindGcd(a, b);
        int lcm = FindLcm(a, b, gcd);

        Console.WriteLine("GCD: " + gcd);
        Console.WriteLine("LCM: " + lcm);
    }

    static int FindGcd(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int FindLcm(int a, int b, int gcd)
    {
        return (a * b) / gcd;
    }
}
