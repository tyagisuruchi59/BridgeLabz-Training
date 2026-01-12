using System;
using System.IO;

class ReadConsoleAndWriteToFile
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter("output.txt"))
        {
            writer.WriteLine(input);
        }

        Console.WriteLine("Data written to file successfully.");
    }
}
