using System;

class LongestWord
{
    static void Main()
    {
        string sentence = "C Sharp Programming Language";
        Console.WriteLine(FindLongestWord(sentence));
    }

    static string FindLongestWord(string input)
    {
        string longest = "";
        string current = "";

        foreach (char ch in input + " ")
        {
            if (ch != ' ')
                current += ch;
            else
            {
                if (current.Length > longest.Length)
                    longest = current;
                current = "";
            }
        }
        return longest;
    }
}
