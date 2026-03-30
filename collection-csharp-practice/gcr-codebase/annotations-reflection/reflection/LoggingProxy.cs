using System;
using System.Reflection;

interface IGreeting
{
    void SayHello();
}

class Greeting : IGreeting
{
    public void SayHello()
    {
        Console.WriteLine("Hello!");
    }
}

class LoggingProxy
{
    private readonly object _target;

    public LoggingProxy(object target)
    {
        _target = target;
    }

    public object Invoke(string methodName, params object[] args)
    {
        // Log method call
        Console.WriteLine("Calling method: " + methodName);

        // Invoke method using Reflection
        MethodInfo method = _target.GetType().GetMethod(methodName);

        if (method == null)
        {
            throw new Exception("Method not found");
        }

        return method.Invoke(_target, args);
    }
}

class ProxyDemo
{
    static void Main()
    {
        // Main purpose:
        // Demonstrate logging proxy WITHOUT dynamic code generation

        IGreeting greeting = new Greeting();
        LoggingProxy proxy = new LoggingProxy(greeting);

        proxy.Invoke("SayHello");
    }
}
