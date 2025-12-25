using System;

class NumberTypeChecker
{
    // Method to check number type
    public static int CheckNumberType(int number)
    {
        if (number > 0)
            return 1;
        else if (number < 0)
            return -1;
        else
            return 0;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = CheckNumberType(number);

        Console.WriteLine("Result: " + result);
    }
}
