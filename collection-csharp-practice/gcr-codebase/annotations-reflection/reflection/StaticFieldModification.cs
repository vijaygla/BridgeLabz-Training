using System;
using System.Reflection;

class Configuration
{
    private static string API_KEY = "OLD_KEY";
}

class StaticFieldModification
{
    static void Main()
    {
        // Main purpose:
        // Modify private static field using Reflection

        Type type = typeof(Configuration);

        FieldInfo field = type.GetField("API_KEY",
            BindingFlags.Static | BindingFlags.NonPublic);

        field.SetValue(null, "NEW_KEY");

        Console.WriteLine("Updated API Key: " + field.GetValue(null));
    }
}
