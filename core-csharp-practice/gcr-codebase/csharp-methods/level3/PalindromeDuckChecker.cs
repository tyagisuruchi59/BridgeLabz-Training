using System;

// Class name clearly indicates purpose
class PalindromeDuckChecker
{
    // Method to count digits in a number
    public static int CountDigits(int number)
    {
        int count = 0;

        while (number > 0)
        {
            count++;
            number /= 10;
        }

        return count;
    }

    // Method to store digits of number into an array
    public static int[] GetDigits(int number)
    {
        int digitCount = CountDigits(number);
        int[] digits = new int[digitCount];

        for (int index = digitCount - 1; index >= 0; index--)
        {
            digits[index] = number % 10;
            number /= 10;
        }

        return digits;
    }

    // Method to reverse a digits array
    public static int[] ReverseArray(int[] digits)
    {
        int[] reversedDigits = new int[digits.Length];

        for (int i = 0; i < digits.Length; i++)
        {
            reversedDigits[i] = digits[digits.Length - 1 - i];
        }

        return reversedDigits;
    }

    // Method to compare two arrays
    public static bool AreArraysEqual(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
            return false;

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
                return false;
        }

        return true;
    }

    // Method to check Palindrome Number
    public static bool IsPalindrome(int[] digits)
    {
        int[] reversedDigits = ReverseArray(digits);
        return AreArraysEqual(digits, reversedDigits);
    }

    // Method to check Duck Number
    // Duck number contains at least one zero
    public static bool IsDuckNumber(int[] digits)
    {
        foreach (int digit in digits)
        {
            if (digit == 0)
                return true;
        }
        return false;
    }

    // Main Method
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] digits = GetDigits(number);

        Console.WriteLine("\nDigits:");
        foreach (int digit in digits)
        {
            Console.Write(digit + " ");
        }

        Console.WriteLine("\n");

        // Palindrome check
        Console.WriteLine("Is Palindrome Number: " + IsPalindrome(digits));

        // Duck number check
        Console.WriteLine("Is Duck Number: " + IsDuckNumber(digits));
    }
}
