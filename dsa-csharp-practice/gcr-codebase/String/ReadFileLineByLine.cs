using System;
using System.IO;

class ReadFileLineByLine
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("data.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
