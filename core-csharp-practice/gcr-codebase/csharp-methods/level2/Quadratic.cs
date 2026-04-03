using System;

class Quadratic
{
    static double[] FindRoots(double a, double b, double c)
    {
        double delta = b * b - 4 * a * c;

        if (delta < 0) return Array.Empty<double>();

        if (delta == 0)
            return new double[] { -b / (2 * a) };

        return new double[]
        {
            (-b + Math.Sqrt(delta)) / (2 * a),
            (-b - Math.Sqrt(delta)) / (2 * a)
        };
    }

    static void Main()
    {
        Console.Write("Enter a, b, c: ");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        double[] roots = FindRoots(a, b, c);

        if (roots.Length == 0)
            Console.WriteLine("No real roots");
        else
            foreach (double r in roots)
                Console.WriteLine("Root: " + r);
    }
}
