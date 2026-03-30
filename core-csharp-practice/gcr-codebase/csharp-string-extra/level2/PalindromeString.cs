using System;

class PalindromeString {
    static void Main(String[] args) {
        Console.Write("Enter any string: ");
        string s = Console.ReadLine();

        bool ans = PalindromeStringMethod(s);
        Console.WriteLine(ans); 
    }

    static bool PalindromeStringMethod(String s) {
        int start = 0, end = s.Length - 1;

        while(start < end) {
            if(s[start] != s[end]) {
                return false;
            }
            start++;
            end--;
        }

        return true;
    }
}
