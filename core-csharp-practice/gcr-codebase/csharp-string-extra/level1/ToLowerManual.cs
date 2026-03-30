using System;

class ToLowerManual
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string text = Console.ReadLine();

        string manual = ConvertLower(text);
        string builtin = text.ToLower();

        Console.WriteLine("Manual Lowercase: " + manual);
        Console.WriteLine("Built-in Lowercase: " + builtin);
    }

    // Convert uppercase to lowercase using ASCII
    static string ConvertLower(string s)
    {
        string result = "";

        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];

            if (ch >= 'A' && ch <= 'Z')
                result += (char)(ch + 32);
            else
                result += ch;
        }

        return result;
    }
}
