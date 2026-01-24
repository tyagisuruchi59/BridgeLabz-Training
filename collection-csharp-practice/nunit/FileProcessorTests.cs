using NUnit.Framework;
using System.IO;

public class FileProcessor
{
    public void WriteToFile(string file, string content)
    {
        File.WriteAllText(file, content);
    }

    public string ReadFromFile(string file)
    {
        if (!File.Exists(file))
            throw new IOException("File not found");
        return File.ReadAllText(file);
    }
}

[TestFixture]
public class FileProcessorTests
{
    FileProcessor fp;
    string file = "test.txt";

    [SetUp]
    public void Setup()
    {
        fp = new FileProcessor();
    }

    [Test]
    public void Write_And_Read_Test()
    {
        fp.WriteToFile(file, "Hello");
        Assert.AreEqual("Hello", fp.ReadFromFile(file));
    }

    [Test]
    public void File_Not_Found_Test()
    {
        Assert.Throws<IOException>(() => fp.ReadFromFile("nofile.txt"));
    }
}
