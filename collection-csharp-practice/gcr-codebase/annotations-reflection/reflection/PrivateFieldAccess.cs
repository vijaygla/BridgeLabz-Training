using System;
using System.Reflection;

class Person
{
    private int age = 25;
}

class PrivateFieldAccess
{
    static void Main()
    {
        // Main purpose:
        // Access and modify a private field using Reflection

        Person person = new Person();
        Type type = typeof(Person);

        FieldInfo field = type.GetField("age",
            BindingFlags.NonPublic | BindingFlags.Instance);

        field.SetValue(person, 30);

        Console.WriteLine("Updated Age: " + field.GetValue(person));
    }
}
