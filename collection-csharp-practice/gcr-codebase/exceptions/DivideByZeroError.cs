using System;
using System.IO;

class DivideByZeroError
{
    static void Main()
    {
        try
        {
            Console.Write("Enter num1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter num2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 / num2;
            Console.WriteLine($"Result {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("cannot divide by zero");
        }
        catch (FormatException)
        {
            Console.WriteLine("Enter valid input number");
        }
    }
}
