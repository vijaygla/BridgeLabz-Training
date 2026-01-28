using System;
using System.Reflection;

class SampleClass
{
    public int Id;
    private string name;

    public SampleClass() { }
    public SampleClass(int id) { }

    public void Show() { }
    private void Secret() { }
}

class ClassInfoViewer
{
    static void Main()
    {
        // Main purpose:
        // Accept class name and display methods, fields, and constructors

        Console.Write("Enter class name: ");
        string className = Console.ReadLine();

        Type type = Type.GetType(className);

        if (type == null)
        {
            Console.WriteLine("Class not found.");
            return;
        }

        Console.WriteLine("\nMethods:");
        foreach (var method in type.GetMethods(
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
        {
            Console.WriteLine(method.Name);
        }

        Console.WriteLine("\nFields:");
        foreach (var field in type.GetFields(
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
        {
            Console.WriteLine(field.Name);
        }

        Console.WriteLine("\nConstructors:");
        foreach (var ctor in type.GetConstructors())
        {
            Console.WriteLine(ctor);
        }
    }
}
