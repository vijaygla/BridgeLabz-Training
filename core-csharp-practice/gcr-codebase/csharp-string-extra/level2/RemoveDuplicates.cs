using System;

class RemoveDuplicates {
    static void Main(String[] args) {
        Console.Write("Enter any string : ");
        string s = Console.ReadLine();

        string ans = RemoveDuplicatesMethod(s);
        Console.WriteLine(ans);
    }

    static string RemoveDuplicatesMethod(string s) {
        string result = "";

        for(int i=0; i<s.Length; i++) {
            if(!result.Contains(s[i].ToString())) {
                result += s[i];
            }
        }
        return result;
    }
}
