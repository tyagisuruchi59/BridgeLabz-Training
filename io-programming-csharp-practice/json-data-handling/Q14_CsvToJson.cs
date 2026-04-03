using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var lines = File.ReadAllLines("Input/ipl.csv");
        var headers = lines[0].Split(',');

        var list = new List<Dictionary<string, string>>();

        for (int i = 1; i < lines.Length; i++)
        {
            var values = lines[i].Split(',');
            var dict = new Dictionary<string, string>();

            for (int j = 0; j < headers.Length; j++)
                dict[headers[j]] = values[j];

            list.Add(dict);
        }

        File.WriteAllText("Output/data.json",
            JsonConvert.SerializeObject(list, Formatting.Indented));
    }
}
