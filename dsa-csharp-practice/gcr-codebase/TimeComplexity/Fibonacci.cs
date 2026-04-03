using System;
using System.Diagnostics;

class Program
{
    // Recursive Fibonacci O(2^N)
    static int FibonacciRecursive(int n)
    {
        if (n <= 1)
            return n;

        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    // Iterative Fibonacci O(N)
    static int FibonacciIterative(int n)
    {
        if (n <= 1)
            return n;

        int a = 0, b = 1;

        for (int i = 2; i <= n; i++)
        {
            int sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }

    static void Main(string[] args)
    {
        int n = 40;

        Stopwatch swRecursive = new Stopwatch();
        swRecursive.Start();
        int recResult = FibonacciRecursive(n);
        swRecursive.Stop();

        Console.WriteLine("Recursive Fibonacci Result: " + recResult);
        Console.WriteLine("Recursive Time (ms): " + swRecursive.ElapsedMilliseconds);

        Stopwatch swIterative = new Stopwatch();
        swIterative.Start();
        int iterResult = FibonacciIterative(n);
        swIterative.Stop();

        Console.WriteLine("Iterative Fibonacci Result: " + iterResult) ;
        Console.WriteLine("Iterative Time (ms): " + swIterative.ElapsedMilliseconds);
    }
}
