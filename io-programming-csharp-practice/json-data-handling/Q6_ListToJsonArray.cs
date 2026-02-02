using Newtonsoft.Json;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var list = new List<int> { 1, 2, 3 };
        System.Console.WriteLine(JsonConvert.SerializeObject(list));
    }
}
