using System;

// Class to calculate percentage and grade
class StudentGrade
{
    static void Main(string[] args)
    {
        // Input marks
        Console.Write("Enter Physics marks: ");
        double physics = double.Parse(Console.ReadLine());

        Console.Write("Enter Chemistry marks: ");
        double chemistry = double.Parse(Console.ReadLine());

        Console.Write("Enter Maths marks: ");
        double maths = double.Parse(Console.ReadLine());

        // Calculate average
        double average = (physics + chemistry + maths) / 3;

        // Determine grade
        string grade;
        string remarks;

        if (average >= 75)
        {
            grade = "A";
            remarks = "Excellent";
        }
        else if (average >= 60)
        {
            grade = "B";
            remarks = "Good";
        }
        else if (average >= 40)
        {
            grade = "C";
            remarks = "Pass";
        }
        else
        {
            grade = "F";
            remarks = "Fail";
        }

        // Output
        Console.WriteLine($"Average Marks: {average}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Remarks: {remarks}");
    }
}
