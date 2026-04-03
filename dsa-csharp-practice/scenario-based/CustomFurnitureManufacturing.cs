using System;

namespace CustomFurnitureManufacturing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Price list: index = length, value = price
            int[] price = { 0, 2, 5, 7, 8, 0, 14, 0, 0, 0, 0, 0, 25 };
            int rodLength = 12;

            Console.WriteLine(" CUSTOM FURNITURE MANUFACTURING\n");

            // Scenario A
            Console.WriteLine("Scenario A: Maximize Earnings");
            int maxRevenue = MaxRevenue(price, rodLength);
            Console.WriteLine($"Maximum revenue for {rodLength}ft rod: {maxRevenue}\n");

            // Scenario B
            Console.WriteLine("Scenario B: Max Waste = 1ft");
            int maxWaste = 1;
            int revenueWithWaste = MaxRevenueWithWaste(price, rodLength, maxWaste);
            Console.WriteLine($"Best revenue with waste constraint: {revenueWithWaste}\n");

            // Scenario C
            Console.WriteLine("Scenario C: Max Revenue + Minimum Waste");
            BestRevenueAndWaste(price, rodLength, maxWaste);
        }

        // Scenario A: Standard Rod Cutting DP
        static int MaxRevenue(int[] price, int n)
        {
            int[] dp = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                int max = 0;
                for (int j = 1; j <= i && j < price.Length; j++)
                {
                    max = Math.Max(max, price[j] + dp[i - j]);
                }
                dp[i] = max;
            }
            return dp[n];
        }

        // Scenario B: Rod Cutting with Waste Constraint
        static int MaxRevenueWithWaste(int[] price, int n, int maxWaste)
        {
            int best = 0;

            for (int used = n - maxWaste; used <= n; used++)
            {
                int revenue = MaxRevenue(price, used);
                best = Math.Max(best, revenue);
            }
            return best;
        }

        // Scenario C: Show Best Revenue with Minimum Waste
        static void BestRevenueAndWaste(int[] price, int n, int maxWaste)
        {
            int bestRevenue = 0;
            int bestWaste = int.MaxValue;

            for (int used = n - maxWaste; used <= n; used++)
            {
                int revenue = MaxRevenue(price, used);
                int waste = n - used;

                if (revenue > bestRevenue ||
                   (revenue == bestRevenue && waste < bestWaste))
                {
                    bestRevenue = revenue;
                    bestWaste = waste;
                }
            }

            Console.WriteLine($"Best Revenue: {bestRevenue}");
            Console.WriteLine($"Minimum Waste: {bestWaste}ft");
        }
    }
}
