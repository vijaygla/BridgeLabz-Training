using System;
using System.Diagnostics;
using System.IO;

class FileBenchmark
{
    // Time: Both O(N) proportional to file size | Space: O(1) streaming buffer
    static void Main()
    {
        string filename = "test500mb.bin";

        // FIX: create file if it does not exist
        if (!File.Exists(filename))
        {
            File.WriteAllBytes(filename, new byte[500 * 1024 * 1024]);
        }

        byte[] buffer = new byte[8192];

        // FileStream (binary efficient)
        var sw = Stopwatch.StartNew();
        long bytesRead = 0;

        using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
        {
            int read;
            while ((read = fs.Read(buffer, 0, buffer.Length)) > 0)
            {
                bytesRead += read;
            }
        }

        sw.Stop();
        Console.WriteLine("FileStream 500MB: " + sw.ElapsedMilliseconds + "ms");

        // StreamReader (text)
        sw.Restart();
        using (StreamReader sr = new StreamReader(filename))
        {
            while (sr.ReadLine() != null) { }
        }

        sw.Stop();
        Console.WriteLine("StreamReader 500MB: " + sw.ElapsedMilliseconds + "ms");
        Console.WriteLine("Time Complexity: Both O(N) | Space: O(1) buffered");
    }
}
