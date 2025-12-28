using System;

class FormatExceptionDemo
{
    static void Main()
    {
        try
        {
            int num = int.Parse("ABC"); // not number
        }
        catch (FormatException e)
        {
            Console.WriteLine("FormatException caught");
            Console.WriteLine(e.Message);
        }
    }
}
