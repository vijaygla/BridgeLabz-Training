using System;
using System.Collections.Generic;
using System.IO;

class Student
{
    public int Id;
    public string Name;
    public int Age;
}

class CsvToObject
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        var lines = File.ReadAllLines("students.csv");

        for (int i = 1; i < lines.Length; i++)
        {
            var d = lines[i].Split(',');
            students.Add(new Student
            {
                Id = int.Parse(d[0]),
                Name = d[1],
                Age = int.Parse(d[2])
            });
        }

        students.ForEach(s => Console.WriteLine($"{s.Id} {s.Name} {s.Age}"));
    }
}
