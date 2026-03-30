using System;

class RemoveSpecificCharacter {
    static void Main(String[] args) {
        Console.Write("Enter any string: ");
        string s = Console.ReadLine();
        Console.Write("Enter any one character: ");
        char c = char.Parse(Console.ReadLine());

        string ans = RemoveSpecificChar(s, c);
        Console.WriteLine("String after removing the special character: " + ans);
    }

    static string RemoveSpecificChar(string s, char c) {
        string ans = "";

        for(int i=0; i<s.Length; i++) {
            if(s[i] != c) {
                ans += s[i];
            }
        }

        return ans;
    }
}
