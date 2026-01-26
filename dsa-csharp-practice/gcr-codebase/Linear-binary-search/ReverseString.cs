using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        string input = "hello";
        StringBuilder sb = new StringBuilder();

        // Loop from last character to first
        for (int i = input.Length - 1; i >= 0; i--)
        {
            sb.Append(input[i]); // Append each character
        }

        Console.WriteLine("Reversed String: " + sb.ToString());
    }
}
