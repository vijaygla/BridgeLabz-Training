using System;
using System.IO;

class ReadCsv
{
    static void Main()
    {
        var lines = File.ReadAllLines("students.csv");

        for (int i = 1; i < lines.Length; i++)
        {
            var data = lines[i].Split(',');
            Console.WriteLine($"ID: {data[0]}, Name: {data[1]}, Age: {data[2]}, Marks: {data[3]}");
        }
    }
}
