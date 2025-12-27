using System;

class FibonacciGenerator
{
    static void Main()
    {
        Console.Write("Enter number of terms: ");
        int terms = int.Parse(Console.ReadLine());

        PrintFibonacci(terms);
    }

    static void PrintFibonacci(int n)
    {
        int a = 0, b = 1;

        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");
            int next = a + b;
            a = b;
            b = next;
        }
    }
}
