using System;

class ReplaceWord
{
    static void Main()
    {
        string text = "I love C Sharp";
        Console.WriteLine(Replace(text, "C Sharp", "C#"));
    }

    static string Replace(string input, string oldWord, string newWord)
    {
        string result = "";
        int i = 0;

        while (i < input.Length)
        {
            if (i <= input.Length - oldWord.Length &&
                input.Substring(i, oldWord.Length) == oldWord)
            {
                result += newWord;
                i += oldWord.Length;
            }
            else
            {
                result += input[i];
                i++;
            }
        }
        return result;
    }
}
