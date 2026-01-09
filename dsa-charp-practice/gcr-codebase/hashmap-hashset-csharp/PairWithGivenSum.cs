using System;
using System.Collections.Generic;

class PairWithGivenSum
{
    static void Main(string[] args)
    {
        int[] arr = { 8, 7, 2, 5, 3, 1 };
        int target = 10;

        HashSet<int> set = new HashSet<int>();
        bool found = false;

        foreach (int num in arr)
        {
            if (set.Contains(target - num))
            {
                found = true;
                break;
            }
            set.Add(num);
        }

        Console.WriteLine(found ? "Pair exists" : "Pair does not exist");
        Console.ReadLine();
    }
}
