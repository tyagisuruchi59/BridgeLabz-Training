using System;

class UppercaseConverter
{
    static void Main()
    {
        string text = "Hello World";

        string customUpper = ConvertToUpper(text);
        string builtInUpper = text.ToUpper();

        Console.WriteLine("Custom Uppercase : " + customUpper);
        Console.WriteLine("Built-in Uppercase: " + builtInUpper);
    }

    static string ConvertToUpper(string input)
    {
        char[] result = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];

            if (ch >= 'a' && ch <= 'z')
            {
                result[i] = (char)(ch - 32);
            }
            else
            {
                result[i] = ch;
            }
        }
        return new string(result);
    }
}
