using System;
using System.Reflection;

class Student
{
    public Student()
    {
        Console.WriteLine("Student object created");
    }
}

class DynamicObjectCreation
{
    static void Main()
    {
        // Main purpose:
        // Create object dynamically without using new keyword

        Type type = typeof(Student);
        object obj = Activator.CreateInstance(type);
    }
}
