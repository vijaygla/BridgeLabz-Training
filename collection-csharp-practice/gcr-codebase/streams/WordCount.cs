using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class WordCount
{
    static void Main()
    {
        Dictionary<string, int> words = new Dictionary<string, int>();

        foreach (string line in File.ReadLines("text.txt"))
        {
            foreach (string word in line.Split(' ', ',', '.', '!', '?'))
            {
                if (string.IsNullOrWhiteSpace(word)) continue;

                string key = word.ToLower();

                // Count word frequency
                if (words.ContainsKey(key))
                    words[key]++;
                else
                    words[key] = 1;
            }
        }

        var top5 = words.OrderByDescending(w => w.Value).Take(5);

        foreach (var w in top5)
        {
            Console.WriteLine($"{w.Key} : {w.Value}");
        }
    }
}
