using System;

// Utility class for number checking operations
class NumberChecker
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

    // Method to store digits of the number into an array
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

    // Method to find sum of digits
    public static int FindSumOfDigits(int[] digits)
    {
        int sum = 0;

        foreach (int digit in digits)
        {
            sum += digit;
        }

        return sum;
    }

    // Method to find sum of squares of digits
    public static double FindSumOfSquares(int[] digits)
    {
        double sum = 0;

        foreach (int digit in digits)
        {
            sum += Math.Pow(digit, 2);
        }

        return sum;
    }

    // Method to check Harshad Number
    // A number divisible by sum of its digits
    public static bool IsHarshadNumber(int number, int[] digits)
    {
        int sumOfDigits = FindSumOfDigits(digits);

        if (sumOfDigits == 0)
            return false;

        return number % sumOfDigits == 0;
    }

    // Method to find frequency of each digit
    // 2D array → [digit][frequency]
    public static int[,] FindDigitFrequency(int[] digits)
    {
        int[,] frequency = new int[10, 2];

        // Initialize digit column
        for (int i = 0; i < 10; i++)
        {
            frequency[i, 0] = i;
            frequency[i, 1] = 0;
        }

        // Count frequency
        foreach (int digit in digits)
        {
            frequency[digit, 1]++;
        }

        return frequency;
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

        int sum = FindSumOfDigits(digits);
        double sumOfSquares = FindSumOfSquares(digits);

        Console.WriteLine("Sum of Digits: " + sum);
        Console.WriteLine("Sum of Squares of Digits: " + sumOfSquares);

        Console.WriteLine("Is Harshad Number: " +
            IsHarshadNumber(number, digits));

        // Digit frequency
        int[,] frequency = FindDigitFrequency(digits);

        Console.WriteLine("\nDigit Frequency:");
        Console.WriteLine("Digit\tFrequency");

        for (int i = 0; i < 10; i++)
        {
            if (frequency[i, 1] > 0)
            {
                Console.WriteLine(frequency[i, 0] + "\t" + frequency[i, 1]);
            }
        }
    }
}
