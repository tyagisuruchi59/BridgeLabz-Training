using System;
using System.Text;

class StringConcatenation
{
    static void Main()
    {
        int n = 10000;

        // Using string
        string s = "";
        for (int i = 0; i < n; i++)
            s += i;

        // Using StringBuilder
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
            sb.Append(i);

        Console.WriteLine("String length: " + s.Length);
        Console.WriteLine("StringBuilder length: " + sb.Length);
    }
}
