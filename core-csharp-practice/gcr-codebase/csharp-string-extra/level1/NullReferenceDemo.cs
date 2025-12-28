using System;

class NullReferenceDemo
{
    static void Main()
    {
        try
        {
            string name = null;
            int len = name.Length; // error here
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine("NullReferenceException caught");
            Console.WriteLine(e.Message);
        }
    }
}
