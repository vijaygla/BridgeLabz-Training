using System;

class SearchSentence
{
    static void Main()
    {
        string[] sentences =
        {
            "I love coding",
            "CSharp is great",
            "Learning programming"
        };

        string word = "CSharp";

        // Linear search
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].Contains(word))
            {
                Console.WriteLine("Found in: " + sentences[i]);
                break;
            }
        }
    }
}
