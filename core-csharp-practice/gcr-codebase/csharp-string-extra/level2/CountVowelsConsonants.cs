using System;

class CountVowelsConsonants {
    static void Main(String[] args) {
        Console.Write("Enter any string: ");
        string s = Console.ReadLine();

        CountVowelsConsonantsMethod(s);
    }

    static void CountVowelsConsonantsMethod(string s) {
        int vowelCount = 0, consonantCount = 0;

        for(int i=0; i < s.Length; i++) {
            char c = char.ToLower(s[i]);

            if(c >= 'a' && c <= 'z') {
                if(c == 'a' || c == 'e' ||c == 'i' ||c == 'o' ||c == 'u') {
                    vowelCount++;
                }
                else {
                    consonantCount++;
                }
            }
        }

        Console.WriteLine("Vowel Count: " + vowelCount);
        Console.WriteLine("Consonant Count: " + consonantCount);
    }
}
