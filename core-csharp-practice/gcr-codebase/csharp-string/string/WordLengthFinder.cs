using System;

class WordLengthFinder
{
    static void Main()
    {
        string text = "C Sharp Programming Language";

        string[,] result = SplitWordsAndLengths(text);

        Console.WriteLine("Word\tLength");
        Console.WriteLine("----------------");

        for (int i = 0; i < result.GetLength(0); i++)
        {
            Console.WriteLine(result[i, 0] + "\t" + result[i, 1]);
        }
    }

    // Method to split words and calculate lengths
    static string[,] SplitWordsAndLengths(string input)
    {
        int wordCount = CountWords(input);
        string[,] data = new string[wordCount, 2];

        int index = 0;
        string currentWord = "";

        for (int i = 0; i < GetStringLength(input); i++)
        {
            if (input[i] != ' ')
            {
                currentWord += input[i];
            }
            else
            {
                data[index, 0] = currentWord;
                data[index, 1] = GetStringLength(currentWord).ToString();
                index++;
                currentWord = "";
            }
        }

        // Store last word
        data[index, 0] = currentWord;
        data[index, 1] = GetStringLength(currentWord).ToString();

        return data;
    }

    // Count words manually
    static int CountWords(string text)
    {
        int count = 1;

        for (int i = 0; i < GetStringLength(text); i++)
        {
            if (text[i] == ' ')
            {
                count++;
            }
        }
        return count;
    }

    // Calculate string length manually
    static int GetStringLength(string text)
    {
        int length = 0;
        foreach (char c in text)
        {
            length++;
        }
        return length;
    }
}
