using System;
using System.IO;
using System.Linq;

class SortEmployeeRecordCsv
{
    static void Main()
    {
        var records = File.ReadAllLines("employees.csv")
                          .Skip(1)
                          .Select(l => l.Split(','))
                          .OrderByDescending(d => double.Parse(d[3]))
                          .Take(5);

        foreach (var r in records)
            Console.WriteLine($"{r[1]} - {r[3]}");
    }
}
