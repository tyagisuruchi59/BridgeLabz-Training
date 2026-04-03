using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int n = 100000;

        // STRING CONCATENATION 
        Stopwatch swString = new Stopwatch();
        swString.Start();

        string result = "";
        for (int i = 0; i < n; i++)
        {
            result += i;
        }

        swString.Stop();
        Console.WriteLine("String concatenation time (ms): " + swString.ElapsedMilliseconds);

        // STRINGBUILDER CONCATENATION
        Stopwatch swBuilder = new Stopwatch();
        swBuilder.Start();

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            sb.Append(i);
        }
        string finalResult = sb.ToString();

        swBuilder.Stop();
        Console.WriteLine("StringBuilder concatenation time (ms): " + swBuilder.ElapsedMilliseconds);
    }
}
