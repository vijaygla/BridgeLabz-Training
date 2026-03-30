using System;
using System.IO;

class BinaryData
{
    static void Main()
    {
        using (BinaryWriter bw = new BinaryWriter(File.Open("student.dat", FileMode.Create)))
        {
            bw.Write(101);
            bw.Write("vijay");
            bw.Write(8.5);
        }

        using (BinaryReader br = new BinaryReader(File.Open("student.dat", FileMode.Open)))
        {
            // Read data in same order
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadDouble());
        }
    }
}
