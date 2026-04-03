using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string text = "Contact us at support@example.com and info@company.org";
        var matches = Regex.Matches(text, @"\b[\w.-]+@[\w.-]+\.\w+\b");

        foreach (Match m in matches)
            Console.WriteLine(m.Value);
    }
}
