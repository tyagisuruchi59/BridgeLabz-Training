using System;
using System.Collections.Generic;

namespace Maps
{
    public class MapProblems
    {
        public static void Run()
        {
            WordFrequency();
            InvertMap();
        }

        static void WordFrequency()
        {
            string text = "Hello world hello Java";
            Dictionary<string, int> map = new();

            foreach (var word in text.ToLower().Split())
                map[word] = map.GetValueOrDefault(word, 0) + 1;

            foreach (var kv in map)
                Console.WriteLine($"{kv.Key} : {kv.Value}");
        }

        static void InvertMap()
        {
            Dictionary<string, int> map = new()
            {
                { "A", 1 },
                { "B", 2 },
                { "C", 1 }
            };

            Dictionary<int, List<string>> inverted = new();

            foreach (var kv in map)
            {
                if (!inverted.ContainsKey(kv.Value))
                    inverted[kv.Value] = new List<string>();
                inverted[kv.Value].Add(kv.Key);
            }

            foreach (var kv in inverted)
                Console.WriteLine($"{kv.Key} -> {string.Join(",", kv.Value)}");
        }
    }
}
