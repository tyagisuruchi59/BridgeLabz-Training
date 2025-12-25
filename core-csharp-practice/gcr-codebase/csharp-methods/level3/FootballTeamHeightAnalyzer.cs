using System;

// Class name clearly indicates purpose
class FootballTeamHeightAnalyzer
{
    // Constant for number of players
    private const int NumberOfPlayers = 11;

    // Generate random heights for players (150–250 cm)
    public static int[] GenerateRandomHeights()
    {
        int[] heights = new int[NumberOfPlayers];
        Random random = new Random();

        for (int index = 0; index < heights.Length; index++)
        {
            heights[index] = random.Next(150, 251);
        }

        return heights;
    }

    // Find sum of heights
    public static int FindSum(int[] heights)
    {
        int sum = 0;

        foreach (int height in heights)
        {
            sum += height;
        }

        return sum;
    }

    // Find mean height
    public static double FindMean(int[] heights)
    {
        int sum = FindSum(heights);
        return (double)sum / heights.Length;
    }

    // Find shortest height
    public static int FindShortest(int[] heights)
    {
        int shortest = heights[0];

        foreach (int height in heights)
        {
            if (height < shortest)
            {
                shortest = height;
            }
        }

        return shortest;
    }

    // Find tallest height
    public static int FindTallest(int[] heights)
    {
        int tallest = heights[0];

        foreach (int height in heights)
        {
            if (height > tallest)
            {
                tallest = height;
            }
        }

        return tallest;
    }

    // Main method
    static void Main(string[] args)
    {
        // Generate heights for football players
        int[] playerHeights = GenerateRandomHeights();

        Console.WriteLine("Heights of Football Players (in cm):");
        foreach (int height in playerHeights)
        {
            Console.Write(height + " ");
        }

        Console.WriteLine("\n");

        // Compute results
        int shortestHeight = FindShortest(playerHeights);
        int tallestHeight = FindTallest(playerHeights);
        double meanHeight = FindMean(playerHeights);

        // Display results
        Console.WriteLine("Shortest Height : " + shortestHeight + " cm");
        Console.WriteLine("Tallest Height  : " + tallestHeight + " cm");
        Console.WriteLine("Mean Height     : " + Math.Round(meanHeight, 2) + " cm");
    }
}
