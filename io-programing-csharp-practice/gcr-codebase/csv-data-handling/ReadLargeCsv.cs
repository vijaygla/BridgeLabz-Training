using System;
using System.IO;

class ReadLargeCsv
{
    static void Main()
    {
        using StreamReader sr = new StreamReader("big.csv");
        int count = 0;
        string line;

        while (!sr.EndOfStream)
        {
            for (int i = 0; i < 100 && (line = sr.ReadLine()) != null; i++)
                count++;

            Console.WriteLine($"Processed {count} records");
        }
    }
}
