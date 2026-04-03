using System;

class Circle
{
    private double radius;

    // Default Constructor
    public Circle() : this(1.0) { }

    // Parameterized Constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}
