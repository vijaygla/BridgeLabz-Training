using System;
using System.IO;
using System.Linq;

class DuplicateCsv
{
    static void Main()
    {
        var lines = File.ReadAllLines("big.csv").Skip(1);

        var duplicates = lines
            .GroupBy(l => l.Split(',')[0])
            .Where(g => g.Count() > 1)
            .SelectMany(g => g);

        foreach (var d in duplicates)
            Console.WriteLine(d);
    }
}
