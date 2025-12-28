using System;

class CompareStringsCharAt
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string s1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string s2 = Console.ReadLine();

        bool manualResult = CompareManual(s1, s2);
        bool builtinResult = s1.Equals(s2);

        Console.WriteLine("Manual Compare Result: " + manualResult);
        Console.WriteLine("Built-in Equals Result: " + builtinResult);
    }

    // This method compare string character by character
    static bool CompareManual(string a, string b)
    {
        if (a.Length != b.Length)
            return false;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i])
                return false;
        }

        return true;
    }
}
