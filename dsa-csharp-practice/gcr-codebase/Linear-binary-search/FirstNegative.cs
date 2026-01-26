using System;

class FirstNegative
{
    static void Main()
    {
        int[] arr = { 5, 8, -3, 7, -1 };

        // Linear search
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                Console.WriteLine("First Negative: " + arr[i]);
                break;
            }
        }
    }
}
