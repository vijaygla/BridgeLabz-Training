using System;
using System.Collections.Generic;

// Base role
abstract class JobRole
{
    public string RoleName { get; set; }
}

class SoftwareEngineer : JobRole { }
class DataScientist : JobRole { }

// Generic resume processor
class Resume<T> where T : JobRole
{
    private List<T> resumes = new List<T>();

    public void AddResume(T role)
    {
        resumes.Add(role);
    }

    public void Process()
    {
        foreach (var r in resumes)
            Console.WriteLine("Processing: " + r.RoleName);
    }
}

class Program
{
    static void Main()
    {
        Resume<SoftwareEngineer> resumes = new Resume<SoftwareEngineer>();
        resumes.AddResume(new SoftwareEngineer { RoleName = "Backend Engineer" });
        resumes.Process();
    }
}
