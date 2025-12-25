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

    // Method to check Duck Number
    // A Duck number has at least one zero digit
    public static bool IsDuckNumber(int[] digits)
    {
        foreach (int digit in digits)
        {
            if (digit == 0)
            {
                return true;
            }
        }
        return false;
    }

    // Method to check Armstrong Number
    public static bool IsArmstrongNumber(int number, int[] digits)
    {
        int power = digits.Length;
        int sum = 0;

        foreach (int digit in digits)
        {
            sum += (int)Math.Pow(digit, power);
        }

        return sum == number;
    }

    // Method to find largest and second largest digits
    public static void FindLargestAndSecondLargest(int[] digits,
        out int largest, out int secondLargest)
    {
        largest = int.MinValue;
        secondLargest = int.MinValue;

        foreach (int digit in digits)
        {
            if (digit > largest)
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit != largest)
            {
                secondLargest = digit;
            }
        }
    }

    // Method to find smallest and second smallest digits
    public static void FindSmallestAndSecondSmallest(int[] digits,
        out int smallest, out int secondSmallest)
    {
        smallest = int.MaxValue;
        secondSmallest = int.MaxValue;

        foreach (int digit in digits)
        {
            if (digit < smallest)
            {
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest && digit != smallest)
            {
                secondSmallest = digit;
            }
        }
    }

    // Main Method
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Get digits
        int[] digits = GetDigits(number);

        Console.WriteLine("\nDigits in the number:");
        foreach (int digit in digits)
        {
            Console.Write(digit + " ");
        }

        // Duck Number check
        Console.WriteLine("\n\nIs Duck Number: " + IsDuckNumber(digits));

        // Armstrong Number check
        Console.WriteLine("Is Armstrong Number: " +
            IsArmstrongNumber(number, digits));

        // Largest and Second Largest
        FindLargestAndSecondLargest(digits,
            out int largest, out int secondLargest);

        Console.WriteLine("Largest Digit: " + largest);
        Console.WriteLine("Second Largest Digit: " + secondLargest);

        // Smallest and Second Smallest
        FindSmallestAndSecondSmallest(digits,
            out int smallest, out int secondSmallest);

        Console.WriteLine("Smallest Digit: " + smallest);
        Console.WriteLine("Second Smallest Digit: " + secondSmallest);
    }
}
