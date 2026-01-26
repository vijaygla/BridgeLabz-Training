using System;
using System.IO;

class FileNotFoundException
{
    static void Main()
    {
        try
        {
            // read all the text from the file
            string content = File.ReadAllText("data.txt");
            Console.WriteLine(content);
        }
        catch (IOException)
        {
            // handle the exception file not found
            Console.WriteLine("---> File not found 404");
        }
    }   
}
