using System;

class ReplaceWord
{
    static void Main()
    {
        Console.Write("Enter sentence: ");
        string sentence = Console.ReadLine();

        Console.Write("Word to replace: ");
        string oldWord = Console.ReadLine();

        Console.Write("New word: ");
        string newWord = Console.ReadLine();

        string result = Replace(sentence, oldWord, newWord);
        Console.WriteLine("Updated Sentence: " + result);
    }

    static string Replace(string sentence, string oldWord, string newWord)
    {
        string[] words = sentence.Split(' ');
        string result = "";

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == oldWord)
                result += newWord;
            else
                result += words[i];

            if (i < words.Length - 1)
                result += " ";
        }

        return result;
    }
}
