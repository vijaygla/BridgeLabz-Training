using System;

class SentenceFormatter {
    static void Main(String[] args) {
        Console.Write("Enter any string containing alphabet with punctuation marks: ");
        string s = Console.ReadLine();

        Console.Write("Formatted string: ");
        Console.WriteLine(StringFormatorMethod(s));
    }

    static string StringFormatorMethod(string s) {
        if (s == null || s.Length == 0) {
            return "";
        }

        char[] ans = new char[s.Length * 2];
        int index = 0;

        bool spaceAllowed = false;
        bool capitalise = true;

        for (int i = 0; i < s.Length; i++) {
            char c = s[i];

            // Handle spaces (remove extra spaces)
            if (c == ' ') {
                if (spaceAllowed) {
                    ans[index++] = ' ';
                    spaceAllowed = false;
                }
                continue;
            }

            // Handle punctuation (. ? !)
            if (c == '.' || c == '?' || c == '!') {

                // REMOVE space before punctuation if present
                if (index > 0 && ans[index - 1] == ' ') {
                    index--;
                }

                // Add punctuation
                ans[index++] = c;

                // Handle consecutive punctuation
                while (i + 1 < s.Length && (s[i + 1] == '.' || s[i + 1] == '?' || s[i + 1] == '!')) {
                    ans[index++] = s[++i];
                }

                // Add exactly one space after punctuation (if not end)
                if (i + 1 < s.Length) {
                    ans[index++] = ' ';
                }

                spaceAllowed = false;
                capitalise = true;
                continue;
            }

            // Capitalize first letter of sentence
            if (capitalise && c >= 'a' && c <= 'z') {
                c = (char)(c - 32);
                capitalise = false;
            }

            ans[index++] = c;
            spaceAllowed = true;
        }

        // Remove trailing space
        if (index > 0 && ans[index - 1] == ' ') {
            index--;
        }

        // Build final string manually
        string outputString = "";
        for (int i = 0; i < index; i++) {
            outputString += ans[i];
        }

        return outputString;
    }
}
