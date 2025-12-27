using System;

class RemoveCharacter
{
    static void Main()
    {
        string text = "Hello World";
        char remove = 'l';

        Console.WriteLine(RemoveChar(text, remove));
    }

    static string RemoveChar(string input, char remove)
    {
        string result = "";

        foreach (char ch in input)
        {
            if (ch != remove)
                result += ch;
        }
        return result;
    }
}
