using System;

class LowercaseConverter
{
    static void Main()
    {
        string text = "HELLO World";

        string customLower = ConvertToLower(text);
        string builtInLower = text.ToLower();

        Console.WriteLine("Custom Lowercase : " + customLower);
        Console.WriteLine("Built-in Lowercase: " + builtInLower);
    }

    static string ConvertToLower(string input)
    {
        char[] result = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];

            if (ch >= 'A' && ch <= 'Z')
            {
                result[i] = (char)(ch + 32);
            }
            else
            {
                result[i] = ch;
            }
        }
        return new string(result);
    }
}
