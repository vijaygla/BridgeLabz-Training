using System;
using System.Text;

class ConcatenateStrings
{
    static void Main()
    {
        string[] words = { "C#", " ", "is", " ", "powerful" };
        StringBuilder sb = new StringBuilder();

        // Append all strings
        for (int i = 0; i < words.Length; i++)
        {
            sb.Append(words[i]);
        }

        Console.WriteLine("Result: " + sb.ToString());
    }
}
