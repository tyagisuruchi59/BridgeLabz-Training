using System;

// Class name clearly indicates purpose
class GeometryCalculator
{
    // Method to find Euclidean distance between two points
    public static double FindDistance(double x1, double y1, double x2, double y2)
    {
        double xDifference = x2 - x1;
        double yDifference = y2 - y1;

        return Math.Sqrt(
            Math.Pow(xDifference, 2) + Math.Pow(yDifference, 2)
        );
    }

    // Method to find slope and y-intercept of a line
    // Returns array: [0] = slope (m), [1] = y-intercept (b)
    public static double[] FindLineEquation(double x1, double y1, double x2, double y2)
    {
        double slope = (y2 - y1) / (x2 - x1);
        double intercept = y1 - (slope * x1);

        return new double[] { slope, intercept };
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

        // Calculate distance
        double distance = FindDistance(x1, y1, x2, y2);

        // Calculate line equation
        double[] line = FindLineEquation(x1, y1, x2, y2);

        // Display results
        Console.WriteLine("\nEuclidean Distance: " + Math.Round(distance, 2));
        Console.WriteLine("Equation of Line: y = " +
            Math.Round(line[0], 2) + "x + " +
            Math.Round(line[1], 2));
    }
}
