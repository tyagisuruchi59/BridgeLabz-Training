using System;

class FirstNegativeNumberLinearSearch
{
    static void Main()
    {
        int[] arr = { 5, 10, -3, 7 };

        foreach (int num in arr)
        {
            if (num < 0)
            {
                Console.WriteLine("First Negative Number: " + num);
                break;
            }
        }
    }
}
