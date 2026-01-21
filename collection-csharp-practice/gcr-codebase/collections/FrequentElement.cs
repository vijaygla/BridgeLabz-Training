using System;
using System.Collections;
using System.Collections.Generic;

// calculate frequent method
class FrequentElementUsingDictionary
{
    static Dictionary<string, int> CalculateFrequency(List<string> list)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();

        foreach(var item in list)
        {
            dict[item] = dict.ContainsKey(item) ? dict[item] + 1 : 1;
        }
        return dict;
    }

    // main method
    static void Main(String[] args)
    {
        List<string> list = new List<string>() { "apple", "banana", "apple", "orange", "banana", "apple"};

        Dictionary<string, int> ans = CalculateFrequency(list);

        Console.WriteLine("Frequent Element in dictionary :- ");

        foreach(var v in ans)
        {
            Console.WriteLine($"{v.Key} : {v.Value}");
        }
    }
}
