using System;

class CheckNumbe {
    static void Main(String[] args) {
        int[] nums = new int[5];

        for(int i=0; i<nums.Length; i++) {
            Console.Write("Enter num " + (i+1) + ": ");
            nums[i] = int.Parse(Console.ReadLine());
        }
        
        for(int i=0; i<nums.Length; i++) {
            if(nums[i] > 0) {
                Console.WriteLine(nums[i] + " is Positive");

                if(nums[i] % 2 == 0) {
                    Console.WriteLine(nums[i] + " is even number");
                }
                else {
                    Console.WriteLine(nums[i] + " is odd number");
                }
            }
            else {
                Console.WriteLine(nums[i] + " is negative number");
            }
        }

        if(nums[0] == nums[nums.Length-1]) {
            Console.WriteLine("Both are equal");
        }
        else if(nums[0] > nums[nums.Length-1]) {
            Console.WriteLine("First is greater than the second");
        }
        else {
            Console.WriteLine("First is smaller than the last");
        }
    }
}
