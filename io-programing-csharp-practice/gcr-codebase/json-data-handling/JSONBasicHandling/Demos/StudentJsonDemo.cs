using System;
using Newtonsoft.Json;
using JSONBasicHandling.Models;

namespace JSONBasicHandling.Demos
{
    public class StudentJsonDemo
    {
        public static void Run()
        {
            Student s = new Student
            {
                Name = "Rahul",
                Age = 22,
                Subjects = new[] { "Math", "Physics", "C#" }
            };

            string json = JsonConvert.SerializeObject(s, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
