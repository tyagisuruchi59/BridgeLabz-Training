using System;

class MostFrequentChar
{
    static void Main()
    {
        string text = "success";
        Console.WriteLine(FindMostFrequent(text));
    }

    static char FindMostFrequent(string input)
    {
        int maxCount = 0;
        char result = input[0];

        foreach (char ch in input)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (c == ch)
                    count++;
            }

            if (count > maxCount)
            {
                maxCount = count;
                result = ch;
            }
        }
        return result;
    }
}
