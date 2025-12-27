using System;

class PalindromeCheck
{
    static void Main()
    {
        string text = "madam";
        Console.WriteLine(IsPalindrome(text) ? "Palindrome" : "Not Palindrome");
    }

    static bool IsPalindrome(string input)
    {
        int start = 0;
        int end = input.Length - 1;

        while (start < end)
        {
            if (input[start] != input[end])
                return false;

            start++;
            end--;
        }
        return true;
    }
}

