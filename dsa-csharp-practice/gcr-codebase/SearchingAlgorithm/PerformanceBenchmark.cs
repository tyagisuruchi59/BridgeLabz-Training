using System;
using System.Diagnostics;

class PerformanceBenchmark
{
    static void Main()
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();

        for (int i = 0; i < 1_000_000; i++) { }

        sw.Stop();
        Console.WriteLine("Time taken: " + sw.ElapsedMilliseconds + " ms");
    }
}
