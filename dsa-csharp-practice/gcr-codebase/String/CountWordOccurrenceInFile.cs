using System;
using System.IO;

class CountWordOccurrenceInFile
{
    static void Main()
    {
        string searchWord = "hello";
        int count = 0;

        using (StreamReader reader = new StreamReader("data.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.Split(' ');
                foreach (string word in words)
                {
                    if (word.Equals(searchWord, StringComparison.OrdinalIgnoreCase))
                        count++;
                }
            }
        }

        Console.WriteLine($"Word '{searchWord}' appears {count} times.");
    }
}
