using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class SerializeDemo
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Vijay", Department = "IT", Salary = 50000 },
            new Employee { Id = 2, Name = "Riya", Department = "HR", Salary = 45000 }
        };

        string path = "employees.json";

        try
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                TypeInfoResolver = new DefaultJsonTypeInfoResolver()
            };

            // Serialize object to JSON file
            string json = JsonSerializer.Serialize(employees, options);
            File.WriteAllText(path, json);

            // Deserialize back to object
            string readJson = File.ReadAllText(path);
            List<Employee> result =
                JsonSerializer.Deserialize<List<Employee>>(readJson, options);

            foreach (var e in result)
            {
                Console.WriteLine($"{e.Id} {e.Name} {e.Department} {e.Salary}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
