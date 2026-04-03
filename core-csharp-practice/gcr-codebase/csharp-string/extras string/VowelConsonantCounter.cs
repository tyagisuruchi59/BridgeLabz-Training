using System;

class VowelConsonantCounter
{
    static void Main()
    {
        string text = "Hello World";
        CountVowelsAndConsonants(text);
    }

    static void CountVowelsAndConsonants(string input)
    {
        int vowels = 0, consonants = 0;

        foreach (char ch in input.ToLower())
        {
            if (ch >= 'a' && ch <= 'z')
            {
                if ("aeiou".IndexOf(ch) != -1)
                    vowels++;
                else
                    consonants++;
            }
        }

        Console.WriteLine("Vowels: " + vowels);
        Console.WriteLine("Consonants: " + consonants);
    }
}
