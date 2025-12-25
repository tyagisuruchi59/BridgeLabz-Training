using System;

class NumberAnalysis
{
    static bool IsPositive(int n) => n >= 0;
    static bool IsEven(int n) => n % 2 == 0;

    static int Compare(int a, int b)
    {
        if (a > b) return 1;
        if (a == b) return 0;
        return -1;
    }

    static void Main()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());

            if (IsPositive(numbers[i]))
                Console.WriteLine(IsEven(numbers[i]) ? "Positive Even" : "Positive Odd");
            else
                Console.WriteLine("Negative");
        }

        int result = Compare(numbers[0], numbers[^1]);
        Console.WriteLine(result == 1 ? "First is Greater" :
                          result == 0 ? "Equal" : "First is Smaller");
    }
}
