using System;
using System.IO;

class BinaryDataStream
{
    static void Main()
    {
        string file = "student.dat";

        using (BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Create)))
        {
            bw.Write(101);
            bw.Write("Suru");
            bw.Write(9.2);
        }

        using (BinaryReader br = new BinaryReader(File.Open(file, FileMode.Open)))
        {
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadDouble());
        }
    }
}
