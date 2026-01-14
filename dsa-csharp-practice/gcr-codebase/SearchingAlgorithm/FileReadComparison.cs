using System;
using System.IO;

class FileReadComparison
{
    static void Main()
    {
        string path = "sample.txt";

        // Using StreamReader
        using (StreamReader reader = new StreamReader(path))
        {
            while (!reader.EndOfStream)
            {
                reader.ReadLine();
            }
        }

        // Using FileStream
        using (FileStream fs = new FileStream(path, FileMode.Open))
        {
            byte[] buffer = new byte[1024];
            while (fs.Read(buffer, 0, buffer.Length) > 0) { }
        }

        Console.WriteLine("File read completed");
    }
}
