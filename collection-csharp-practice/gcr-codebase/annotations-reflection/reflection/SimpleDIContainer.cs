using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
class InjectAttribute : Attribute { }

class Service
{
    public void Serve() => Console.WriteLine("Service Executed");
}

class Client
{
    [Inject]
    public Service service;
}

class SimpleDIContainer
{
    static void Main()
    {
        // Main purpose:
        // Inject dependencies dynamically using Reflection

        Client client = new Client();
        InjectDependencies(client);

        client.service.Serve();
    }

    static void InjectDependencies(object obj)
    {
        foreach (var field in obj.GetType().GetFields())
        {
            if (Attribute.IsDefined(field, typeof(InjectAttribute)))
            {
                object dependency = Activator.CreateInstance(field.FieldType);
                field.SetValue(obj, dependency);
            }
        }
    }
}
