using System;
using System.Reflection;

class Calculator
{
    private int Multiply(int a, int b)
    {
        return a * b;
    }
}

class InvokePrivateMethod
{
    static void Main()
    {
        // Main purpose:
        // Invoke a private method using Reflection

        Calculator calc = new Calculator();
        Type type = typeof(Calculator);

        MethodInfo method = type.GetMethod("Multiply",
            BindingFlags.NonPublic | BindingFlags.Instance);

        object result = method.Invoke(calc, new object[] { 4, 5 });

        Console.WriteLine("Result: " + result);
    }
}
