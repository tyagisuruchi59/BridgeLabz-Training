using System;

class ReverseString
{
    static void Main()
    {
        string text = "Hello";
        Console.WriteLine(Reverse(text));
    }

    static string Reverse(string input)
    {
        char[] result = new char[input.Length];
        int index = 0;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            result[index++] = input[i];
        }

        return new string(result);
    }
}
