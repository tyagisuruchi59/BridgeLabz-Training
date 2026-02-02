using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

class JsonIplProcessor
{
    static void Main()
    {
        var matches = JsonConvert.DeserializeObject<List<IplMatch>>(
            File.ReadAllText("Input/ipl.json"));

        foreach (var m in matches)
        {
            m.team1 = MaskService.MaskTeam(m.team1);
            m.team2 = MaskService.MaskTeam(m.team2);
            m.winner = MaskService.MaskTeam(m.winner);
            m.player_of_match = "REDACTED";
        }

        File.WriteAllText("Output/ipl_censored.json",
            JsonConvert.SerializeObject(matches, Formatting.Indented));
    }
}
