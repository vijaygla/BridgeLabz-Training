using System;
using System.Collections.Generic;

class LongestConsecutiveSequence
{
    static void Main(string[] args)
    {
        int[] arr = { 100, 4, 200, 1, 3, 2 };
        HashSet<int> set = new HashSet<int>(arr);

        int longest = 0;

        foreach (int num in set)
        {
            if (!set.Contains(num - 1))
            {
                int current = num;
                int count = 1;

                while (set.Contains(current + 1))
                {
                    current++;
                    count++;
                }

                longest = Math.Max(longest, count);
            }
        }

        Console.WriteLine("Longest sequence length: " + longest);
        Console.ReadLine();
    }
}
