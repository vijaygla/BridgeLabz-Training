using System;
using System.IO;

class FileReadWrite
{
    static void Main(string[] args)
    {
        string sourcePath = "source.txt";
        string destinationPath = "destination.txt";

        try
        {
            if (!File.Exists(sourcePath))
            {
                Console.WriteLine("Source file does not exist");
                return;
            }

            using (FileStream fsRead = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(destinationPath, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[1024];
                int bytesRead;

                // Read from source and write to destination
                while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fsWrite.Write(buffer, 0, bytesRead);
                }
            }

            Console.WriteLine("File copied successfully");
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
