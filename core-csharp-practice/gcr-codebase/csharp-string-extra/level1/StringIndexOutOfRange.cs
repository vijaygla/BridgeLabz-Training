using System;

class StringIndexOutOfRange
{
    static void Main()
    {
        try
        {
            string text = "Hello";
            char ch = text[10]; // wrong index
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("IndexOutOfRangeException caught");
            Console.WriteLine(e.Message);
        }
    }
}
