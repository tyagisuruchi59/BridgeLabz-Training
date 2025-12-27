using System;

class SubstringCount
{
    static void Main()
    {
        string text = "abababa";
        string sub = "aba";

        Console.WriteLine(CountOccurrences(text, sub));
    }

    static int CountOccurrences(string text, string sub)
    {
        int count = 0;

        for (int i = 0; i <= text.Length - sub.Length; i++)
        {
            if (text.Substring(i, sub.Length) == sub)
                count++;
        }
        return count;
    }
}
