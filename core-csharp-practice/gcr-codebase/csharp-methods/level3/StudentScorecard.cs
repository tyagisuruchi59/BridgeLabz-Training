using System;

// Class name clearly indicates purpose
class StudentScorecard
{
    // Subject count: Physics, Chemistry, Maths
    private const int SubjectCount = 3;

    // Method to generate random PCM marks for students
    // Returns 2D array: rows = students, columns = subjects
    public static int[,] GeneratePcmMarks(int studentCount)
    {
        int[,] marks = new int[studentCount, SubjectCount];
        Random random = new Random();

        for (int student = 0; student < studentCount; student++)
        {
            for (int subject = 0; subject < SubjectCount; subject++)
            {
                marks[student, subject] = random.Next(10, 100); // 2-digit marks
            }
        }

        return marks;
    }

    // Method to calculate Total, Average, Percentage
    // Returns 2D array: Total, Average, Percentage
    public static double[,] CalculateResults(int[,] marks)
    {
        int studentCount = marks.GetLength(0);
        double[,] results = new double[studentCount, 3];

        for (int student = 0; student < studentCount; student++)
        {
            int total = 0;

            for (int subject = 0; subject < SubjectCount; subject++)
            {
                total += marks[student, subject];
            }

            double average = (double)total / SubjectCount;
            double percentage = (double)total / (SubjectCount * 100) * 100;

            results[student, 0] = total;
            results[student, 1] = Math.Round(average, 2);
            results[student, 2] = Math.Round(percentage, 2);
        }

        return results;
    }

    // Method to display scorecard
    public static void DisplayScorecard(int[,] marks, double[,] results)
    {
        Console.WriteLine("\nStudent\tPhysics\tChemistry\tMaths\tTotal\tAverage\tPercentage");

        for (int student = 0; student < marks.GetLength(0); student++)
        {
            Console.Write((student + 1) + "\t");

            for (int subject = 0; subject < SubjectCount; subject++)
            {
                Console.Write(marks[student, subject] + "\t\t");
            }

            Console.Write(
                results[student, 0] + "\t" +
                results[student, 1] + "\t" +
                results[student, 2]
            );

            Console.WriteLine();
        }
    }

    // Main Method
    static void Main(string[] args)
    {
        Console.Write("Enter number of students: ");
        int studentCount = Convert.ToInt32(Console.ReadLine());

        int[,] marks = GeneratePcmMarks(studentCount);
        double[,] results = CalculateResults(marks);
        DisplayScorecard(marks, results);
    }
}
