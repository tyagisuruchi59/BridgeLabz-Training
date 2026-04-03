using System;

class MeanHeight
{
    static void Main(string[] args)
    {
        double[] heights = new double[11];
        double sum = 0;

        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write($"Enter height {i + 1}: ");
            if (!double.TryParse(Console.ReadLine(), out heights[i]))
            {
                Console.Error.WriteLine("Invalid input.");
                Environment.Exit(1);
            }
            sum += heights[i];
        }

        double mean = sum / heights.Length;
        Console.WriteLine($"Mean Height = {mean}");
    }
}
