using System;

class BMICalculator
{
    static double CalculateBMI(double weight, double heightCm)
    {
        double heightM = heightCm / 100;
        return weight / (heightM * heightM);
    }

    static string GetStatus(double bmi)
    {
        if (bmi < 18.5) return "Underweight";
        if (bmi < 25) return "Normal";
        if (bmi < 30) return "Overweight";
        return "Obese";
    }

    static void Main()
    {
        double[,] data = new double[10, 3];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Weight (kg): ");
            data[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Height (cm): ");
            data[i, 1] = Convert.ToDouble(Console.ReadLine());

            data[i, 2] = CalculateBMI(data[i, 0], data[i, 1]);
            Console.WriteLine("BMI Status: " + GetStatus(data[i, 2]));
        }
    }
}
