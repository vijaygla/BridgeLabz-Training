using System;
using System.IO;
using System.Text.RegularExpressions;

class ValidateCsv
{
    static void Main()
    {
        Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        Regex phoneRegex = new Regex(@"^\d{10}$");

        var lines = File.ReadAllLines("users.csv");

        for (int i = 1; i < lines.Length; i++)
        {
            var d = lines[i].Split(',');

            if (!emailRegex.IsMatch(d[2]) || !phoneRegex.IsMatch(d[3]))
                Console.WriteLine($"Invalid Row: {lines[i]}");
        }
    }
}
