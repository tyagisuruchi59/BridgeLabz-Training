using System;
using System.Text.RegularExpressions;

class ExtractLinks
{
    static void Main()
    {
        string text = "Visit https://www.google.com and http://example.org";
        var matches = Regex.Matches(text, @"https?://\S+");

        foreach (Match m in matches)
            Console.WriteLine(m.Value);
    }
}
