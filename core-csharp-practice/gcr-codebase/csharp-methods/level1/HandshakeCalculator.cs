using System;

class HandshakeCalculator
{
    // Method to calculate handshakes
    public static int CalculateHandshakes(int numberOfStudents)
    {
        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;
        return handshakes;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        int result = CalculateHandshakes(numberOfStudents);

        Console.WriteLine("Maximum number of handshakes: " + result);
    }
}
