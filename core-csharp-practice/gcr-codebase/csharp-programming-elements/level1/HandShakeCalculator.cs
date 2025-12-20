using System;

class HandshakeCalculator
{
    static void Main()
    {
        int numberOfStudents;
        int handshakes;

        Console.Write("Enter number of students: ");
        numberOfStudents = Convert.ToInt32(Console.ReadLine());

        handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        Console.WriteLine(
            "The maximum number of handshakes is " + handshakes
        );
    }
}
