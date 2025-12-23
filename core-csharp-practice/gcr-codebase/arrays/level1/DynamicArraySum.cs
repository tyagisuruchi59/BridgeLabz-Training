using System;

class DynamicArraySum
{
    static void Main(string[] args)
    {
        double[] values = new double[10];
        int index = 0;
        double total = 0.0;

        while (true)
        {
            Console.Write("Enter a number: ");
            if (!double.TryParse(Console.ReadLine(), out double input))
            {
                Console.Error.WriteLine("Invalid input.");
                Environment.Exit(1);
            }

            if (input <= 0 || index == values.Length)
                break;

            values[index++] = input;
        }

        for (int i = 0; i < index; i++)
            total += values[i];

        Console.WriteLine($"Total Sum = {total}");
    }
}
