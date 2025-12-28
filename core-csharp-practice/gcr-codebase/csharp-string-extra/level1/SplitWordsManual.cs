using System;

class SplitWordsManual
{
    static void Main()
    {
        Console.Write("Enter sentence: ");
        string text = Console.ReadLine();

        string[,] result = SplitAndCount(text);

        Console.WriteLine("Word\tLength");
        for (int i = 0; i < result.GetLength(0); i++)
        {
            Console.WriteLine(result[i, 0] + "\t" + result[i, 1]);
        }
    }

    // Split words manually and count length manually
    static string[,] SplitAndCount(string s)
    {
        string[] words = new string[50];
        int wordCount = 0;
        string currentWord = "";

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != ' ')
            {
                currentWord += s[i];
            }
            else
            {
                words[wordCount++] = currentWord;
                currentWord = "";
            }
        }

        words[wordCount++] = currentWord;

        string[,] result = new string[wordCount, 2];

        for (int i = 0; i < wordCount; i++)
        {
            result[i, 0] = words[i];
            result[i, 1] = CountLength(words[i]).ToString();
        }

        return result;
    }

    // Count length without using Length property
    static int CountLength(string s)
    {
        int count = 0;
        foreach (char c in s)
            count++;

        return count;
    }
}
