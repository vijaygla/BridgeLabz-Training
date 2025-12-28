using System;

class ArgumentOutOfRangeDemo
{
    static void Main()
    {
        try
        {
            string text = "Hello";
            string sub = text.Substring(4, 10); // invalid range
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("ArgumentOutOfRangeException caught");
            Console.WriteLine(e.Message);
        }
    }
}
