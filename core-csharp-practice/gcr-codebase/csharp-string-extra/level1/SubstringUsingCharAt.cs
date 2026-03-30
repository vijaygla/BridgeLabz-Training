using System;

class SubstringUsingCharAt
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string text = Console.ReadLine();

        Console.Write("Enter start index: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter end index: ");
        int end = int.Parse(Console.ReadLine());

        string manual = CreateSubstring(text, start, end);
        string builtin = text.Substring(start, end - start);

        Console.WriteLine("Manual Substring: " + manual);
        Console.WriteLine("Built-in Substring: " + builtin);
    }

    // This method create substring using index logic
    static string CreateSubstring(string s, int start, int end)
    {
        string result = "";

        for (int i = start; i < end; i++)
        {
            result += s[i];
        }

        return result;
    }
}
