using System;

class YoungestAndTallest
{
    static void Main(string[] args)
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Take input
        for (int i = 0; i < names.Length; i++)
        {
            Console.Write($"Enter age of {names[i]}: ");
            if (!int.TryParse(Console.ReadLine(), out ages[i]) || ages[i] <= 0)
            {
                Console.Error.WriteLine("Invalid age.");
                return;
            }

            Console.Write($"Enter height of {names[i]}: ");
            if (!double.TryParse(Console.ReadLine(), out heights[i]) || heights[i] <= 0)
            {
                Console.Error.WriteLine("Invalid height.");
                return;
            }
        }

        int youngestIndex = 0;
        int tallestIndex = 0;

        for (int i = 1; i < names.Length; i++)
        {
            if (ages[i] < ages[youngestIndex])
                youngestIndex = i;

            if (heights[i] > heights[tallestIndex])
                tallestIndex = i;
        }

        Console.WriteLine($"Youngest Friend : {names[youngestIndex]}");
        Console.WriteLine($"Tallest Friend  : {names[tallestIndex]}");
    }
}
