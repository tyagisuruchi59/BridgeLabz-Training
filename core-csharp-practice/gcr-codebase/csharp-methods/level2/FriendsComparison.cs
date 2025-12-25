using System;

class FriendsComparison
{
    static int FindYoungest(int[] ages)
    {
        int min = ages[0];
        foreach (int age in ages)
            if (age < min) min = age;
        return min;
    }

    static double FindTallest(double[] heights)
    {
        double max = heights[0];
        foreach (double h in heights)
            if (h > max) max = h;
        return max;
    }

    static void Main()
    {
        int[] ages = new int[3];
        double[] heights = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter age of friend {i + 1}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter height of friend {i + 1}: ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("Youngest Age: " + FindYoungest(ages));
        Console.WriteLine("Tallest Height: " + FindTallest(heights));
    }
}
