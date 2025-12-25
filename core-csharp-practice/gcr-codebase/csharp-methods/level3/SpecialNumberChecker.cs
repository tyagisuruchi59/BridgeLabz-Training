using System;

// Class name clearly indicates purpose
class SpecialNumberChecker
{
    // Method to check Prime Number
    public static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
                return false;
        }

        return true;
    }

    // Method to check Neon Number
    // Neon number: sum of digits of square == number
    public static bool IsNeonNumber(int number)
    {
        int square = number * number;
        int sum = 0;

        while (square > 0)
        {
            sum += square % 10;
            square /= 10;
        }

        return sum == number;
    }

    // Method to check Spy Number
    // Spy number: sum of digits == product of digits
    public static bool IsSpyNumber(int number)
    {
        int sum = 0;
        int product = 1;

        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            product *= digit;
            number /= 10;
        }

        return sum == product;
    }

    // Method to check Automorphic Number
    // Square of number ends with the number itself
    public static bool IsAutomorphicNumber(int number)
    {
        int square = number * number;
        int temp = number;

        while (temp > 0)
        {
            if (temp % 10 != square % 10)
                return false;

            temp /= 10;
            square /= 10;
        }

        return true;
    }

    // Method to check Buzz Number
    // Buzz number: divisible by 7 or ends with 7
    public static bool IsBuzzNumber(int number)
    {
        return (number % 7 == 0) || (number % 10 == 7);
    }

    // Main Method
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nPrime Number: " + IsPrime(number));
        Console.WriteLine("Neon Number: " + IsNeonNumber(number));
        Console.WriteLine("Spy Number: " + IsSpyNumber(number));
        Console.WriteLine("Automorphic Number: " + IsAutomorphicNumber(number));
        Console.WriteLine("Buzz Number: " + IsBuzzNumber(number));
    }
}
