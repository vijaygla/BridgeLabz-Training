using System;
using System.IO;

class ErrorFinder
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("largefile.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Check for word "error" ignoring case
                if (line.ToLower().Contains("error"))
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
