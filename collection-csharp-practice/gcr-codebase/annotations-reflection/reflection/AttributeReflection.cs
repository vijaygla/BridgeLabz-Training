using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute
{
    public string Name { get; }
    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

[Author("John Doe")]
class Book { }

class AttributeReflection
{
    static void Main()
    {
        // Main purpose:
        // Retrieve custom attribute value using Reflection

        Type type = typeof(Book);
        AuthorAttribute attribute =
            (AuthorAttribute)Attribute.GetCustomAttribute(type, typeof(AuthorAttribute));

        Console.WriteLine("Author: " + attribute.Name);
    }
}
