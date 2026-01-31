using System;
using System.Collections.Generic;
using System.Text;

namespace WordAnalyzer
{
    public class Utility
    {
        // method to check reverse
        public string ReverseCheck(string word1, string word2)
        {
            char[] arr1 = word1.ToCharArray();
            Array.Reverse(arr1);
            string reverse1 = new string(arr1);

            StringBuilder sb = new StringBuilder();

            // Case 1: If word2 is reverse of word1
            if (reverse1.Equals(word2, StringComparison.OrdinalIgnoreCase))
            {
                foreach (char c in reverse1.ToLower())
                {
                    if ("aeiou".Contains(c))
                        sb.Append('@');
                    else
                        sb.Append(c);
                }
                return sb.ToString();
            }
            else
            {
                // Case 2: Not reverse
                string combined = (word1 + word2).ToUpper();

                int vowelCount = 0;
                int consonantCount = 0;

                foreach (char c in combined)
                {
                    if ("AEIOU".Contains(c))
                        vowelCount++;
                    else
                        consonantCount++;
                }

                HashSet<char> set = new HashSet<char>();

                if (vowelCount > consonantCount)
                {
                    foreach (char c in combined)
                    {
                        if ("AEIOU".Contains(c))
                            set.Add(c);
                    }
                }
                else if (vowelCount == consonantCount)
                {
                    Console.WriteLine("Both count are equal");
                }
                else
                {
                    foreach (char c in combined)
                    {
                        if (!"AEIOU".Contains(c))
                            set.Add(c);
                    }
                }

                // Take first two characters safely
                foreach (char c in set)
                {
                    sb.Append(c);
                    if (sb.Length == 2)
                        break;
                }

                return sb.ToString();
            }
        }
    }
}
