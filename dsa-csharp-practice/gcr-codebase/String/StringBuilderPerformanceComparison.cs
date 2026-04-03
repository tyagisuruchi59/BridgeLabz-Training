using System;
using System.Diagnostics;
using System.Text;

class StringBuilderPerformanceComparison
{
    static void Main()
    {
        int count = 100000;

        Stopwatch sw = new Stopwatch();

        sw.Start();
        string str = "";
        for (int i = 0; i < count; i++)
            str += "a";
        sw.Stop();
        Console.WriteLine("String Time: " + sw.ElapsedMilliseconds + " ms");

        sw.Restart();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < count; i++)
            sb.Append("a");
        sw.Stop();
        Console.WriteLine("StringBuilder Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
