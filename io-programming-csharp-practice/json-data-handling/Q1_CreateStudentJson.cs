using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        var student = new
        {
            name = "Suru",
            age = 22,
            subjects = new[] { "C#", "DSA", "JSON" }
        };

        string json = JsonConvert.SerializeObject(student, Formatting.Indented);
        System.Console.WriteLine(json);
    }
}
