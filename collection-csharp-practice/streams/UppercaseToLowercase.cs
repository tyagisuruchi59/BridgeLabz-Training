using System;
using System.IO;

class UppercaseToLowercase
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("input.txt"))
        using (StreamWriter writer = new StreamWriter("output.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine(line.ToLower());
            }
        }

        Console.WriteLine("Conversion done.");
    }
}
