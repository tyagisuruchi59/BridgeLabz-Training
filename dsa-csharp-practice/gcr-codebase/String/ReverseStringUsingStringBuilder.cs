using System;
using System.Text;

class ReverseStringUsingStringBuilder
{
    static void Main()
    {
        string input = "hello";
        StringBuilder sb = new StringBuilder(input);

        for (int i = 0, j = sb.Length - 1; i < j; i++, j--)
        {
            char temp = sb[i];
            sb[i] = sb[j];
            sb[j] = temp;
        }

        Console.WriteLine("Reversed String: " + sb);
    }
}
