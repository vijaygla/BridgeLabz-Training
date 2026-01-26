using System;

class FinallyExample
{
    static void Main()
    {
        try
        {
            Console.Write("Enter numerator: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter denominator: ");
            int b = int.Parse(Console.ReadLine());

            int result = a / b;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            // Always executed
            Console.WriteLine("Operation completed");
        }
    }
}
