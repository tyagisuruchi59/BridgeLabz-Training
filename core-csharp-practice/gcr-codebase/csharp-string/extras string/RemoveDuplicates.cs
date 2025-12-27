using System;

class RemoveDuplicates
{
    static void Main()
    {
        string text = "programming";
        Console.WriteLine(RemoveDuplicateChars(text));
    }

    static string RemoveDuplicateChars(string input)
    {
        string result = "";

        foreach (char ch in input)
        {
            if (!result.Contains(ch))
                result += ch;
        }
        return result;
    }
}
