using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class WordCount
{
    static void Main()
    {
        Dictionary<string, int> map = new Dictionary<string, int>();

        using (StreamReader reader = new StreamReader("textfile.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                foreach (string word in line.ToLower().Split(' ', ',', '.', '!'))
                {
                    if (word == "") continue;
                    map[word] = map.ContainsKey(word) ? map[word] + 1 : 1;
                }
            }
        }

        foreach (var item in map.OrderByDescending(x => x.Value).Take(5))
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }
}
