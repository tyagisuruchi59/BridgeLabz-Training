using System;
using System.Text.RegularExpressions;

class ValidateCreditCard
{
    static void Main()
    {
        string visa = "4123456789012345";
        string master = "5123456789012345";

        Console.WriteLine(Regex.IsMatch(visa, @"^4\d{15}$") ? "Visa Valid" : "Visa Invalid");
        Console.WriteLine(Regex.IsMatch(master, @"^5\d{15}$") ? "MasterCard Valid" : "MasterCard Invalid");
    }
}
