using System;

// Class to calculate BMI
class BMICalculator
{
    static void Main(string[] args)
    {
        Console.Write("Enter weight in kg: ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Enter height in cm: ");
        double heightCm = double.Parse(Console.ReadLine());

        // Convert height to meters
        double heightMeter = heightCm / 100;

        // Calculate BMI
        double bmi = weight / (heightMeter * heightMeter);

        Console.WriteLine($"BMI is {bmi}");

        if (bmi < 18.5)
            Console.WriteLine("Underweight");
        else if (bmi < 25)
            Console.WriteLine("Normal");
        else if (bmi < 30)
            Console.WriteLine("Overweight");
        else
            Console.WriteLine("Obese");
    }
}
