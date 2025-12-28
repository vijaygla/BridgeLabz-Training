using System;

class WithoutToCharArray
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string text = Console.ReadLine();

        char[] manual = GetChars(text);
        char[] builtin = text.ToCharArray();

        Console.WriteLine("Manual Characters:");
        foreach (char c in manual)
            Console.Write(c + " ");

        Console.WriteLine("\nBuilt-in Characters:");
        foreach (char c in builtin)
            Console.Write(c + " ");
    }

    // This method return char array without ToCharArray
    static char[] GetChars(string s)
    {
        char[] arr = new char[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            arr[i] = s[i];
        }

        return arr;
    }
}
