using System;
using System.Collections.Generic;

namespace Systems
{
    public class VotingSystem
    {
        public static void Run()
        {
            Dictionary<string, int> votes = new();
            votes["Alice"] = 3;
            votes["Bob"] = 1;

            foreach (var v in votes)
                Console.WriteLine($"{v.Key}: {v.Value}");
        }
    }
}
