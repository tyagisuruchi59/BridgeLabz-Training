using System;
using System.Text;

class ConcatenateStringsUsingStringBuilder
{
    static void Main()
    {
        string[] words = { "Hello", " ", "World", "!" };
        StringBuilder sb = new StringBuilder();

        foreach (string word in words)
        {
            sb.Append(word);
        }

        Console.WriteLine("Concatenated String: " + sb);
    }
}
