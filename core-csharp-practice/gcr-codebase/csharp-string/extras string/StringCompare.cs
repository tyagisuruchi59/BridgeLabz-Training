using System;

class StringCompare
{
    static void Main()
    {
        string s1 = "apple";
        string s2 = "banana";

        CompareStrings(s1, s2);
    }

    static void CompareStrings(string s1, string s2)
    {
        int minLength = Math.Min(s1.Length, s2.Length);

        for (int i = 0; i < minLength; i++)
        {
            if (s1[i] < s2[i])
            {
                Console.WriteLine($"\"{s1}\" comes before \"{s2}\"");
                return;
            }
            else if (s1[i] > s2[i])
            {
                Console.WriteLine($"\"{s2}\" comes before \"{s1}\"");
                return;
            }
        }

        if (s1.Length == s2.Length)
            Console.WriteLine("Both strings are equal");
        else if (s1.Length < s2.Length)
            Console.WriteLine($"\"{s1}\" comes before \"{s2}\"");
        else
            Console.WriteLine($"\"{s2}\" comes before \"{s1}\"");
    }
}
