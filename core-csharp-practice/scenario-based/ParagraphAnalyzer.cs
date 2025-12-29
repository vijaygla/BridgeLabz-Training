using System;

class ParagraphAnalyzer
{
    static void Main()
    {
        Console.Write("Enter any paragraph: ");
        string paragraph = Console.ReadLine();

        if (paragraph == null || IsEmptyMethod(paragraph))
        {
            Console.WriteLine("The paragraph is empty or contains only spaces.");
            return;
        }

        // Count words
        int wordCount = CountWords(paragraph);
        Console.WriteLine("Number of words: " + wordCount);

        // Find longest word
        string longestWord = FindLongestWord(paragraph);
        Console.WriteLine("Longest word: " + longestWord);

        // Replace word
        Console.Write("Enter the word to replace: ");
        string oldWord = Console.ReadLine();
        Console.Write("Enter the new word: ");
        string newWord = Console.ReadLine();

        string replacedParagraph = ReplaceWord(paragraph, oldWord, newWord);
        Console.WriteLine("Updated paragraph:");
        Console.WriteLine(replacedParagraph);
    }

    // Check if string is empty or only spaces
    static bool IsEmptyMethod(string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != ' ') return false;
        }
        return true;
    }

    // Count words manually
    static int CountWords(string s)
    {
        s =             a
        int count = 0;
        for(int i=0; i<s.Length-1; i++) {
            if(s[i] == ' ' && s[i+1] != ' ') {
                count++;
            }
        }
        return count+1;
    }

    // Find the longest word manually
    static string FindLongestWord(string s)
    {
        string longest = "";
        string current = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != ' ')
            {
                current += s[i];
            }
            else
            {
                if (current.Length > longest.Length)
                    longest = current;
                current = "";
            }
        }
        if (current.Length > longest.Length) // last word
            longest = current;
        return longest;
    }

    // Compare two strings manually (case-insensitive)
    static bool CompareIgnoreCase(string a, string b)
    {
        if (a.Length != b.Length) return false;
        for (int i = 0; i < a.Length; i++)
        {
            char ca = a[i];
            char cb = b[i];

            // Convert uppercase to lowercase manually
            if (ca >= 'A' && ca <= 'Z') ca = (char)(ca + 32);
            if (cb >= 'A' && cb <= 'Z') cb = (char)(cb + 32);

            if (ca != cb) return false;
        }
        return true;
    }

    // Replace word manually
    static string ReplaceWord(string paragraph, string oldWord, string newWord)
    {
        if (oldWord == null || oldWord.Length == 0) return paragraph;

        string result = "";
        string current = "";
        for (int i = 0; i < paragraph.Length; i++)
        {
            char c = paragraph[i];
            if (c != ' ')
            {
                current += c;
            }
            else
            {
                if (CompareIgnoreCase(current, oldWord))
                    result += newWord;
                else
                    result += current;

                result += ' ';
                current = "";
            }
        }

        // Check last word
        if (CompareIgnoreCase(current, oldWord))
            result += newWord;
        else
            result += current;
        
        return result;
    }
}

