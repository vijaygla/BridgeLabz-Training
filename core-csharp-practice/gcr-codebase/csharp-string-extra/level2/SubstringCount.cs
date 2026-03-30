using System;

class SubstringCount {
    static void Main() {
        Console.Write("Enter string: ");
        string text = Console.ReadLine();

        Console.Write("Enter substring: ");
        string sub = Console.ReadLine();

        int count = CountOccurrences(text, sub);
        Console.WriteLine("Occurrences: " + count);
    }

    static int CountOccurrences(string text, string sub) {
        int count = 0;

        for (int i = 0; i <= text.Length - sub.Length; i++) {
            bool match = true;

            for (int j = 0; j < sub.Length; j++) {
                if (text[i + j] != sub[j]) {
                    match = false;
                    break;
                }
            }

            if (match) count++;
        }

        return count;
    }
}
