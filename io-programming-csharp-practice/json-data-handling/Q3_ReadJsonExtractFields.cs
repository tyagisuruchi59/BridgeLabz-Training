using Newtonsoft.Json.Linq;
using System.IO;

class Program
{
    static void Main()
    {
        var users = JArray.Parse(File.ReadAllText("Input/users.json"));
        foreach (var u in users)
            System.Console.WriteLine($"{u["name"]} - {u["email"]}");
    }
}
