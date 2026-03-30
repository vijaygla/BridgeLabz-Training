using System;
using System.Diagnostics;
using System.IO;

class BufferedCopy
{
    static void Main()
    {
        string source = "source.txt";
        string dest = "destination.txt";

        if (!File.Exists(source))
        {
            Console.WriteLine("Source file not found");
            return;
        }

        byte[] buffer = new byte[4096];
        Stopwatch sw = new Stopwatch();

        try
        {
            sw.Start();

            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(dest, FileMode.Create, FileAccess.Write))
            using (BufferedStream bsRead = new BufferedStream(fsRead))
            using (BufferedStream bsWrite = new BufferedStream(fsWrite))
            {
                int bytesRead;

                // Read and write in chunks
                while ((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    bsWrite.Write(buffer, 0, bytesRead);
                }
            }

            sw.Stop();
            Console.WriteLine($"Buffered copy completed in {sw.ElapsedMilliseconds} ms");
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
