using System;

class AnagramCheck
{
    static void Main()
    {
        string s1 = "listen";
        string s2 = "silent";

        Console.WriteLine(IsAnagram(s1, s2) ? "Anagram" : "Not Anagram");
    }

    static bool IsAnagram(string a, string b)
    {
        if (a.Length != b.Length)
            return false;

        foreach (char ch in a)
        {
            int countA = 0, countB = 0;

            foreach (char c in a)
                if (c == ch) countA++;

            foreach (char c in b)
                if (c == ch) countB++;

            if (countA != countB)
                return false;
        }
        return true;
    }
}
