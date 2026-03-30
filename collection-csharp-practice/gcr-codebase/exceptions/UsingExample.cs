using System;
using System.IO;

class UsingExample
{
    static void Main()
    {
        try
        {
            // using ensure file is closed acutomatically
            using (StreamReader render = new StreamReader("info.txt"))
            {
                Console.WriteLine(render.ReadLine());
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading file");
        }
    }
}
