using System;
using System.Collections.Generic;
using System.Reflection;

class User
{
    public string Name;
    public int Age;
}

class ObjectMapper
{
    static void Main()
    {
        // Main purpose:
        // Map dictionary values to object fields using Reflection

        var data = new Dictionary<string, object>
        {
            { "Name", "vijay" },
            { "Age", 20 }
        };

        User user = ToObject<User>(typeof(User), data);

        Console.WriteLine($"{user.Name} - {user.Age}");
    }

    static T ToObject<T>(Type clazz, Dictionary<string, object> properties)
    {
        object obj = Activator.CreateInstance(clazz);

        foreach (var prop in properties)
        {
            FieldInfo field = clazz.GetField(prop.Key);
            field?.SetValue(obj, prop.Value);
        }

        return (T)obj;
    }
}
