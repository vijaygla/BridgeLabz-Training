using System;
using System.IO;

public class CountStudentRecord
{
    static void Main(String[] args)
    {
        var lines = File.ReadAllLines("students.csv");
        Console.WriteLine($"Total number of record : {lines.Length - 1}");
    }
}
