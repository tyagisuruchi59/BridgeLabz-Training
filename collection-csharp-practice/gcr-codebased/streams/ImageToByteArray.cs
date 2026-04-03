using System;
using System.IO;

class ImageToByteArray
{
    static void Main()
    {
        string sourceImage = "original.jpg";
        string copiedImage = "copy.jpg";

        try
        {
            byte[] bytes;

            using (FileStream fs = new FileStream(sourceImage, FileMode.Open))
            using (MemoryStream ms = new MemoryStream())
            {
                fs.CopyTo(ms);
                bytes = ms.ToArray();
            }

            File.WriteAllBytes(copiedImage, bytes);
            Console.WriteLine("Image copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
