using System;

class MostFrequentCharacter
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char result = FindMostFrequent(input);
        Console.WriteLine("Most Frequent Character: " + result);
    }

    static char FindMostFrequent(string s) {
        int maxCount = 0;
        char mostFrequentChar = s[0];

        for(int i=0; i<s.Length; i++) {
            int count = 0;
            for(int j=0; j<s.Length; j++) {
                if(s[i] == s[j]) {
                    count++;
                }
            }
            if(count > maxCount) {
                maxCount = count;
                mostFrequentChar = s[i];
            }
        }

        return mostFrequentChar;
    }
}
