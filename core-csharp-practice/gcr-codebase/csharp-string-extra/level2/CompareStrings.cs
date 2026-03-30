using System;

class CompareStrings
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string s1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string s2 = Console.ReadLine();

        Compare(s1, s2);
    }

    static void Compare(string s1, string s2)
    {
        int minLength = (s1.Length < s2.Length) ? s1.Length : s2.Length;

        for (int i = 0; i < minLength; i++)
        {
            if (s1[i] < s2[i])
            {
                Console.WriteLine("\"" + s1 + "\" comes before \"" + s2 + "\"");
                return;
            }
            else if (s1[i] > s2[i])
            {
                Console.WriteLine("\"" + s2 + "\" comes before \"" + s1 + "\"");
                return;
            }
        }

        if (s1.Length < s2.Length)
            Console.WriteLine("\"" + s1 + "\" comes before \"" + s2 + "\"");
        else if (s1.Length > s2.Length)
            Console.WriteLine("\"" + s2 + "\" comes before \"" + s1 + "\"");
        else
            Console.WriteLine("Both strings are equal");
    }
}
