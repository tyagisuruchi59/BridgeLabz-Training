using System;

class DisplayResult
{
    static void Main()
    {
        string name = "Sam";
        int rollNumber = 1;
        double percentMarks = 99.99;
        char result = 'P';

        Console.WriteLine(
            $"Displaying Result:\n{name} with Roll Number {rollNumber} has Scored {percentMarks}% Marks and Result is {result}"
        );
    }
}
