using System;

class PalindromeChecker
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        DisplayResult(IsPalindrome(input));
    }

    static bool IsPalindrome(string text)
    {
        int start = 0, end = text.Length - 1;

        while (start < end)
        {
            if (text[start] != text[end])
                return false;
            start++;
            end--;
        }
        return true;
    }

    static void DisplayResult(bool result)
    {
        Console.WriteLine(result ? "Palindrome" : "Not Palindrome");
    }
}
