using System;
using System.Collections.Generic;

class LongestSubstringWithoutReapting {

    public int LengthOfLongestSubstring(string s) {
        int maxLength = 0;

        for(int i = 0; i < s.Length; i++) {
            HashSet<char> set = new HashSet<char>();

            for(int j = i; j < s.Length; j++) {
                if(set.Contains(s[j])) {
                    break;
                }
                set.Add(s[j]);
                maxLength = Math.Max(maxLength, j - i + 1);
            }
        }

        return maxLength;
    }

    static void Main(String[] args) {
        LongestSubstringWithoutReapting obj = new LongestSubstringWithoutReapting();

        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int result = obj.LengthOfLongestSubstring(input);
        Console.WriteLine("Length of longest substring without repeating characters: " + result);
    }
}
