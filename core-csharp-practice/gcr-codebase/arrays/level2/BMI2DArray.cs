using System;

class BMI2DArray
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of persons: ");
        int number = int.Parse(Console.ReadLine());

        double[][] personData = new double[number][];
        string[] weightStatus = new string[number];

        for (int i = 0; i < number; i++)
        {
            personData[i] = new double[3];

            Console.Write("Enter height: ");
            personData[i][0] = double.Parse(Console.ReadLine());

            Console.Write("Enter weight: ");
            personData[i][1] = double.Parse(Console.ReadLine());

            personData[i][2] = personData[i][1] / (personData[i][0] * personData[i][0]);

            weightStatus[i] = personData[i][2] < 18.5 ? "Underweight"
                              : personData[i][2] < 25 ? "Normal"
                              : personData[i][2] < 30 ? "Overweight" : "Obese";
        }

        for (int i = 0; i < number; i++)
            Console.WriteLine($"BMI: {personData[i][2]}, Status: {weightStatus[i]}");
    }
}
