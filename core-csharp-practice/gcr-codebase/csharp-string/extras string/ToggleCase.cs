using System;

class ToggleCase
{
    static void Main()
    {
        string text = "HeLLo";
        Console.WriteLine(Toggle(text));
    }

    static string Toggle(string input)
    {
        char[] result = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];

            if (ch >= 'A' && ch <= 'Z')
                result[i] = (char)(ch + 32);
            else if (ch >= 'a' && ch <= 'z')
                result[i] = (char)(ch - 32);
            else
                result[i] = ch;
        }
        return new string(result);
    }
}
