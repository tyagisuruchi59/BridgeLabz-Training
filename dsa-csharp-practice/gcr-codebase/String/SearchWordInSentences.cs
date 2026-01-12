using System;

class SearchWordInSentences
{
    static void Main()
    {
        string[] sentences =
        {
            "I love programming",
            "C# is powerful",
            "Data Structures are important"
        };

        string word = "powerful";

        foreach (string sentence in sentences)
        {
            if (sentence.Contains(word))
            {
                Console.WriteLine("Found in: " + sentence);
                break;
            }
        }
    }
}
