using System;

// Class name clearly indicates purpose
class CollinearPointsChecker
{
    // Method to check collinearity using slope method
    public static bool AreCollinearBySlope(
        double x1, double y1,
        double x2, double y2,
        double x3, double y3)
    {
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);

        return slopeAB == slopeBC && slopeBC == slopeAC;
    }

    // Method to check collinearity using area of triangle method
    public static bool AreCollinearByArea(
        double x1, double y1,
        double x2, double y2,
        double x3, double y3)
    {
        double area = 0.5 * (
            x1 * (y2 - y3) +
            x2 * (y3 - y1) +
            x3 * (y1 - y2)
        );

        return Math.Abs(area) == 0;
    }

    // Main Method
    static void Main(string[] args)
    {
        // Input points
        Console.Write("Enter x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter x3: ");
        double x3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y3: ");
        double y3 = Convert.ToDouble(Console.ReadLine());

        // Check collinearity
        bool slopeResult = AreCollinearBySlope(x1, y1, x2, y2, x3, y3);
        bool areaResult = AreCollinearByArea(x1, y1, x2, y2, x3, y3);

        // Display results
        Console.WriteLine("\nCollinear using Slope Method: " + slopeResult);
        Console.WriteLine("Collinear using Area Method : " + areaResult);
    }
}
