using System.IO;
using System.Collections.Generic;

class CsvIplProcessor
{
    static void Main()
    {
        var lines = File.ReadAllLines("Input/ipl.csv");
        var output = new List<string> { lines[0] };

        for (int i = 1; i < lines.Length; i++)
        {
            var c = lines[i].Split(',');
            c[1] = MaskService.MaskTeam(c[1]);
            c[2] = MaskService.MaskTeam(c[2]);
            c[5] = MaskService.MaskTeam(c[5]);
            c[6] = "REDACTED";
            output.Add(string.Join(",", c));
        }

        File.WriteAllLines("Output/ipl_censored.csv", output);
    }
}
