using Newtonsoft.Json.Linq;
using System.IO;

class Program
{
    static void Main()
    {
        JObject obj = JObject.Parse(File.ReadAllText("Input/users.json"));
        foreach (var p in obj.Properties())
            System.Console.WriteLine($"{p.Name} : {p.Value}");
    }
}
