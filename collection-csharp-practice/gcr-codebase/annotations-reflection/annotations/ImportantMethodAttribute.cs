using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class ImportantMethodAttribute : Attribute
{
    public string Level { get; }

    public ImportantMethodAttribute(string level = "HIGH")
    {
        Level = level;
    }
}

class Service
{
    [ImportantMethod]
    public void Save() { }

    [ImportantMethod("LOW")]
    public void Log() { }
}

class Program
{
    static void Main()
    {
        foreach (var method in typeof(Service).GetMethods())
        {
            var attr = method.GetCustomAttribute<ImportantMethodAttribute>();
            if (attr != null)
                Console.WriteLine($"{method.Name} - {attr.Level}");
        }
    }
}
