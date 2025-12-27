using System;

class ArrayExceptionDemo
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30 };

        try
        {
            // Invalid index access
            Console.WriteLine(numbers[5]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Exception caught: IndexOutOfRangeException");
            Console.WriteLine(ex.Message);
        }
    }
}
