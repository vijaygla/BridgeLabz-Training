using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class TodoAttribute : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

class Project
{
    [Todo("Implement login", "Vijay", "HIGH")]
    public void Login() { }

    [Todo("Add validation", "Kumar")]
    public void Register() { }
}

class Program
{
    static void Main()
    {
        foreach (var method in typeof(Project).GetMethods())
        {
            var attr = method.GetCustomAttribute<TodoAttribute>();
            if (attr != null)
                Console.WriteLine($"{attr.Task} - {attr.AssignedTo} - {attr.Priority}");
        }
    }
}
