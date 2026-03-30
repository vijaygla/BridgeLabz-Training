using System;
using System.IO;

class ImageByteArray
{
    static void Main()
    {
        byte[] imageBytes = File.ReadAllBytes("input.jpeg");

        using (MemoryStream ms = new MemoryStream(imageBytes))
        {
            // Write same bytes back to another image
            File.WriteAllBytes("output.jpeg", ms.ToArray());
        }

        Console.WriteLine("Image copied successfully");
    }
}
