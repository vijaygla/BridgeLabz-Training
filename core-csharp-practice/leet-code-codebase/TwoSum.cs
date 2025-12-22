using System;

class TwoSum
{
    static void Main(string[] args)
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = FindTwoSum(nums, target);

        Console.WriteLine("Output: " + "[ " + result[0] + " , " + result[1] + " ]");
    }

    static int[] FindTwoSum(int[] nums, int target)
    {
        int[] ans = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    ans[0] = i;
                    ans[1] = j;
                    return ans;
                }
            }
        }
        return ans;
    }
}
