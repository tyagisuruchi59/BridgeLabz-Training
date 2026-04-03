using System;
using System.Diagnostics;
using System.IO;

class BufferedFileCopy
{
    static void Main()
    {
        string source = "bigfile.dat";
        string normalCopy = "normal.dat";
        string bufferedCopy = "buffered.dat";

        CopyNormal(source, normalCopy);
        CopyBuffered(source, bufferedCopy);
    }

    static void CopyNormal(string source, string dest)
    {
        Stopwatch sw = Stopwatch.StartNew();

        using (FileStream read = new FileStream(source, FileMode.Open))
        using (FileStream write = new FileStream(dest, FileMode.Create))
        {
            byte[] buffer = new byte[4096];
            int readBytes;

            while ((readBytes = read.Read(buffer, 0, buffer.Length)) > 0)
            {
                write.Write(buffer, 0, readBytes);
            }
        }

        sw.Stop();
        Console.WriteLine("Normal Stream Time: " + sw.ElapsedMilliseconds + " ms");
    }

    static void CopyBuffered(string source, string dest)
    {
        Stopwatch sw = Stopwatch.StartNew();

        using (BufferedStream read = new BufferedStream(new FileStream(source, FileMode.Open)))
        using (BufferedStream write = new BufferedStream(new FileStream(dest, FileMode.Create)))
        {
            byte[] buffer = new byte[4096];
            int readBytes;

            while ((readBytes = read.Read(buffer, 0, buffer.Length)) > 0)
            {
                write.Write(buffer, 0, readBytes);
            }
        }

        sw.Stop();
        Console.WriteLine("Buffered Stream Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
