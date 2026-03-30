using System;

class ToggleCase
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string toggled = Toggle(input);
        Console.WriteLine("Toggled String: " + toggled);
    }

    static string Toggle(string s) {
        string ans = "";

        for(int i=0; i<s.Length; i++) {
            char c = s[i];

            if(c >= 'a' && c <= 'z') {
                ans += (char)(c - 32);
            }
            else if(c >= 'A' && c <= 'Z') {
                ans += (char)(c + 32);
            }
            else {
                ans += c;
            }
        }

        return ans;
    }
}
