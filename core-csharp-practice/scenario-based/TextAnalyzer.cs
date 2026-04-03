using System;
using System.Text.RegularExpressions;

class TextAnalyzer
{
    static void Main()
    {
        Console.WriteLine("Enter a paragraph:");
        string paragraph = Console.ReadLine();

        // Edge case: empty or space-only input
        if (string.IsNullOrWhiteSpace(paragraph))
        {
            Console.WriteLine("Paragraph is empty or contains only spaces.");
            return;
        }

        // Remove extra spaces and split into words
        string[] words = paragraph
            .Trim()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // Count words
        int wordCount = words.Length;
        Console.WriteLine("Word Count: " + wordCount);

        // Find longest word
        string longestWord = "";
        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }
        Console.WriteLine("Longest Word: " + longestWord);

        // Word replacement (case-insensitive)
        Console.WriteLine("Enter word to replace:");
        string oldWord = Console.ReadLine();

        Console.WriteLine("Enter replacement word:");
        string newWord = Console.ReadLine();

        string updatedParagraph = Regex.Replace(
            paragraph,
            @"\b" + Regex.Escape(oldWord) + @"\b",
            newWord,
            RegexOptions.IgnoreCase
        );

        Console.WriteLine("Updated Paragraph:");
        Console.WriteLine(updatedParagraph);
    }
}
