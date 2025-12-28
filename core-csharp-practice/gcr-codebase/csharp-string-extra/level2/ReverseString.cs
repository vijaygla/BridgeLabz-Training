using System;

class ReverseString {
    static void Main(String[] args) {
        Console.Write("Enter any string: ");
        String s = Console.ReadLine();

        string result = reverseStringMethod(s);
        Console.WriteLine("Reversed string : "+ result);
    }

    static string reverseStringMethod(string s) {
        string reverse = "";
        
        for(int i=s.Length-1; i>=0; i--) {
            reverse += s[i];
        }

        return reverse;
    }
}
