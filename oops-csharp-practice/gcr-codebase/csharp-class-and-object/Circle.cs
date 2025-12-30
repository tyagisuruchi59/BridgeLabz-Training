using System;

class Circle
{
    double radius;

    // Constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Method to calculate area
    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    // Method to calculate circumference
    public double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }

    static void Main()
    {
        Circle circle = new Circle(5);

        Console.WriteLine("Area of Circle: " + circle.CalculateArea());
        Console.WriteLine("Circumference of Circle: " + circle.CalculateCircumference());
    }
}
