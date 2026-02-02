using Newtonsoft.Json.Linq;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        var users = JArray.Parse(File.ReadAllText("Input/users.json"));
        var result = users.Where(u => (int)u["age"] > 25);
        System.Console.WriteLine(result);
    }
}
