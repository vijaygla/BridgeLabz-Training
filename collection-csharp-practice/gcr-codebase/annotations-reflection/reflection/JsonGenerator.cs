using System;
using System.Reflection;
using System.Text;

class Product
{
    public int Id;
    public string Name;
}

class JsonGenerator
{
    static void Main()
    {
        // Main purpose:
        // Convert object to JSON-like string using Reflection

        Product p = new Product { Id = 1, Name = "Laptop" };
        Console.WriteLine(ToJson(p));
    }

    static string ToJson(object obj)
    {
        Type type = obj.GetType();
        FieldInfo[] fields = type.GetFields();

        StringBuilder json = new StringBuilder("{ ");

        foreach (var field in fields)
        {
            json.Append($"\"{field.Name}\": \"{field.GetValue(obj)}\", ");
        }

        json.Length -= 2;
        json.Append(" }");

        return json.ToString();
    }
}
