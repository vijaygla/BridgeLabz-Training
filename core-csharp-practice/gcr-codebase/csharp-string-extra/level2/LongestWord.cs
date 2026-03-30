using System;

class LongestWord{
    static void Main(){
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        string longest = FindLongestWord(sentence);
        Console.WriteLine("Longest Word: " + longest);
    }

    static string FindLongestWord(string sentence){
        string[] words = sentence.Split(' ');
        string longest = words[0];

        for(int i=1; i<words.Length; i++) {
            if(words[i].Length > longest.Length) {
                longest = words[i];
            }
        }

        return longest;
    }
}
