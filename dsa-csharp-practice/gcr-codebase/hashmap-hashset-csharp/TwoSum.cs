using System;
using System.Collections.Generic;

class TwoSum
{
    static void Main(string[] args)
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int needed = target - nums[i];

            if (map.ContainsKey(needed))
            {
                Console.WriteLine("Indices: " + map[needed] + " and " + i);
                Console.ReadLine();
                return;
            }

            map[nums[i]] = i;
        }

        Console.WriteLine("No solution found");
        Console.ReadLine();
    }
}
