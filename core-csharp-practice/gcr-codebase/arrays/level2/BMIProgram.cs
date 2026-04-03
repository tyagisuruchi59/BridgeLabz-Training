using System;

class BMIProgram
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of persons: ");
        if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
        {
            Console.Error.WriteLine("Invalid input.");
            return;
        }

        double[] height = new double[count];
        double[] weight = new double[count];
        double[] bmi = new double[count];
        string[] status = new string[count];

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Enter height (m) of person {i + 1}: ");
            height[i] = double.Parse(Console.ReadLine());

            Console.Write($"Enter weight (kg) of person {i + 1}: ");
            weight[i] = double.Parse(Console.ReadLine());

            bmi[i] = weight[i] / (height[i] * height[i]);

            if (bmi[i] < 18.5) status[i] = "Underweight";
            else if (bmi[i] < 25) status[i] = "Normal";
            else if (bmi[i] < 30) status[i] = "Overweight";
            else status[i] = "Obese";
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Person {i + 1}: BMI = {bmi[i]}, Status = {status[i]}");
        }
    }
}
