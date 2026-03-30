using System;

class ToUpperManual
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string text = Console.ReadLine();

        string manual = ConvertUpper(text);
        string builtin = text.ToUpper();

        Console.WriteLine("Manual Uppercase: " + manual);
        Console.WriteLine("Built-in Uppercase: " + builtin);
    }

    // Convert lowercase to uppercase using ASCII
    static string ConvertUpper(string s)
    {
        string result = "";

        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];

            if (ch >= 'a' && ch <= 'z')
                result += (char)(ch - 32);
            else
                result += ch;
        }

        return result;
    }
}
