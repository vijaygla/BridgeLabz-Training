using System;
using System.Text;
using System.Collections.Generic;

class RemoveDuplicates
{
    static void Main()
    {
        string input = "programming";
        StringBuilder sb = new StringBuilder();
        HashSet<char> seen = new HashSet<char>();

        // Traverse input string
        foreach (char ch in input)
        {
            // Add only if character not already seen
            if (!seen.Contains(ch))
            {
                seen.Add(ch);
                sb.Append(ch);
            }
        }

        Console.WriteLine("Without Duplicates: " + sb.ToString());
    }
}
