using System;

class RandomAnalysis
{
    static int[] Generate4DigitRandomArray(int size)
    {
        Random random = new Random();
        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
            numbers[i] = random.Next(1000, 10000);

        return numbers;
    }

    static double[] FindAverageMinMax(int[] numbers)
    {
        int min = numbers[0], max = numbers[0], sum = 0;

        foreach (int n in numbers)
        {
            sum += n;
            min = Math.Min(min, n);
            max = Math.Max(max, n);
        }

        return new double[] { sum / (double)numbers.Length, min, max };
    }

    static void Main()
    {
        int[] numbers = Generate4DigitRandomArray(5);
        double[] result = FindAverageMinMax(numbers);

        Console.WriteLine("Average: " + result[0]);
        Console.WriteLine("Min: " + result[1]);
        Console.WriteLine("Max: " + result[2]);
    }
}
