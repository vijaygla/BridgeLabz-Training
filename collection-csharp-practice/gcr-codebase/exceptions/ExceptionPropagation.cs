using System;

class ExceptionPropagation
{
    static void Method1()
    {
        // Causes ArithmeticException
        int x = 10 / 0;
    }

    static void Method2()
    {
        Method1(); // Exception propagates
    }

    static void Main()
    {
        try
        {
            Method2();
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Handled exception in Main");
        }
    }
}
