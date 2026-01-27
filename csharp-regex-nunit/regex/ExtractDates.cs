using System;
using System.Text.RegularExpressions;

class ExtractDates
{
    static void Main()
    {
        string text = "Dates: 12/05/2023, 15/08/2024, 29/02/2020";
        var matches = Regex.Matches(text, @"\b\d{2}/\d{2}/\d{4}\b");

        foreach (Match m in matches)
            Console.WriteLine(m.Value);
    }
}
