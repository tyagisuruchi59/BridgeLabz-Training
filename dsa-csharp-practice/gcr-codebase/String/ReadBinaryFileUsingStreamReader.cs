using System;
using System.IO;
using System.Text;

class ReadBinaryFileUsingStreamReader
{
    static void Main()
    {
        using (FileStream fs = new FileStream("data.bin", FileMode.Open))
        using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
        {
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}
