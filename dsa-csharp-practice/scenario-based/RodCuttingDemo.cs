using System;

namespace RodCuttingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== STORY 1: METAL FACTORY =====\n");

            int[] metalPrices = { 0, 1, 5, 8, 9, 10, 17, 17, 20 };
            int metalRodLength = 8;

            Console.WriteLine("Scenario A: Optimized Cutting");
            int maxRevenue = RodCutting(metalPrices, metalRodLength);
            Console.WriteLine($"Maximum Revenue for length {metalRodLength}: {maxRevenue}\n");

            Console.WriteLine("Scenario B: Custom Order (Length 5 price updated)");
            metalPrices[5] = 14;
            maxRevenue = RodCutting(metalPrices, metalRodLength);
            Console.WriteLine($"Maximum Revenue after custom order: {maxRevenue}\n");

            Console.WriteLine("Scenario C: Non-Optimized Strategy");
            Console.WriteLine($"Revenue without optimization: {metalPrices[metalRodLength]}\n");

            Console.WriteLine("===== STORY 2: CUSTOM FURNITURE =====\n");

            int[] woodPrices = { 0, 2, 5, 7, 8, 0, 14, 0, 0, 0, 0, 0, 25 };
            int woodRodLength = 12;

            Console.WriteLine("Scenario A: Best Revenue");
            maxRevenue = RodCutting(woodPrices, woodRodLength);
            Console.WriteLine($"Maximum Revenue for 12ft rod: {maxRevenue}\n");

            Console.WriteLine("Scenario B & C: Revenue with Waste Constraint (Max waste = 1ft)");
            maxRevenue = RodCuttingWithWaste(woodPrices, woodRodLength, 1);
            Console.WriteLine($"Best Revenue with minimal waste: {maxRevenue}");
        }

        // Standard Rod Cutting DP
        static int RodCutting(int[] price, int n)
        {
            int[] dp = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                int max = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (j < price.Length)
                        max = Math.Max(max, price[j] + dp[i - j]);
                }
                dp[i] = max;
            }
            return dp[n];
        }

        // Rod Cutting with Waste Constraint
        static int RodCuttingWithWaste(int[] price, int n, int maxWaste)
        {
            int bestRevenue = 0;

            for (int usedLength = n - maxWaste; usedLength <= n; usedLength++)
            {
                int revenue = RodCutting(price, usedLength);
                bestRevenue = Math.Max(bestRevenue, revenue);
            }
            return bestRevenue;
        }
    }
}
