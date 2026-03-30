using System;
using System.Reflection;

class MathOperations
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
}

class DynamicMethodInvocation
{
    static void Main()
    {
        // Main purpose:
        // Invoke method based on user input

        MathOperations math = new MathOperations();
        Type type = typeof(MathOperations);

        Console.Write("Enter method name: ");
        string methodName = Console.ReadLine();

        MethodInfo method = type.GetMethod(methodName);

        object result = method.Invoke(math, new object[] { 10, 5 });

        Console.WriteLine("Result: " + result);
    }
}
