using System;
using System.Text.RegularExpressions;

class ValidateUsername
{
    static void Main()
    {
        string[] usernames = { "user_123", "123user", "us" };
        string pattern = @"^[A-Za-z][A-Za-z0-9_]{4,14}$";

        foreach (var username in usernames)
        {
            Console.WriteLine($"{username} → {(Regex.IsMatch(username, pattern) ? "Valid" : "Invalid")}");
        }
    }
}
