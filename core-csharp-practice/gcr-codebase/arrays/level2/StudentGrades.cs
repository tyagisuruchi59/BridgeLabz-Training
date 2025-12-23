using System;

class StudentGrades
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of students: ");
        int students = int.Parse(Console.ReadLine());

        double[] percentage = new double[students];
        string[] grade = new string[students];

        for (int i = 0; i < students; i++)
        {
            Console.Write("Enter Physics marks: ");
            double p = double.Parse(Console.ReadLine());

            Console.Write("Enter Chemistry marks: ");
            double c = double.Parse(Console.ReadLine());

            Console.Write("Enter Maths marks: ");
            double m = double.Parse(Console.ReadLine());

            percentage[i] = (p + c + m) / 3;

            if (percentage[i] >= 90) grade[i] = "A";
            else if (percentage[i] >= 75) grade[i] = "B";
            else if (percentage[i] >= 60) grade[i] = "C";
            else grade[i] = "D";
        }

        for (int i = 0; i < students; i++)
            Console.WriteLine($"Student {i + 1}: {percentage[i]}% Grade {grade[i]}");
    }
}
