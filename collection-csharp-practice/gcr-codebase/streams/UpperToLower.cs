using System;
using System.IO;

class UpperToLower
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("input.txt"))
        using (StreamWriter writer = new StreamWriter("output.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Convert text to lowercase
                writer.WriteLine(line.ToLower());
            }
        }

        Console.WriteLine("Conversion completed");
    }
}
