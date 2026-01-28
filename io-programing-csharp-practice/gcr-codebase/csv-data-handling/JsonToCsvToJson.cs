using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty; // fixes CS8618
    public int Age { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static void Main()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            TypeInfoResolver = new DefaultJsonTypeInfoResolver()
        };

        // JSON → Object
        var json = File.ReadAllText("students.json");

        var students = JsonSerializer.Deserialize<List<Student>>(json, options)
                       ?? new List<Student>();

        // Object → CSV
        File.WriteAllLines(
            "students.csv",
            new[] { "Id,Name,Age,Marks" }
            .Concat(students.Select(s =>
                $"{s.Id},{s.Name},{s.Age},{s.Marks}"
            ))
        );

        // CSV → Object
        var csvLines = File.ReadAllLines("students.csv").Skip(1);

        var studentsFromCsv = csvLines
            .Select(l => l.Split(','))
            .Select(d => new Student
            {
                Id = int.Parse(d[0]),
                Name = d[1],
                Age = int.Parse(d[2]),
                Marks = int.Parse(d[3])
            })
            .ToList();

        // Object → JSON
        File.WriteAllText(
            "students_from_csv.json",
            JsonSerializer.Serialize(studentsFromCsv, options)
        );

        Console.WriteLine("JSON → CSV → JSON completed successfully ✅");
    }
}
