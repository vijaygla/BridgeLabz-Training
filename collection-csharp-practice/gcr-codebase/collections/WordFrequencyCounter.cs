using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class WordFrequencyCounter
{
    static void Main()
    {
        string text = "Hello world, hello Java!";
        Dictionary<string, int> frequencyMap = new Dictionary<string, int>();

        foreach (string word in Regex.Split(text.ToLower(), @"\W+"))
        {
            if (string.IsNullOrEmpty(word)) continue;

            frequencyMap[word] = frequencyMap.GetValueOrDefault(word, 0) + 1;
        }

        foreach (var entry in frequencyMap)
        {
            Console.WriteLine($"{entry.Key} : {entry.Value}");
        }
    }
}
