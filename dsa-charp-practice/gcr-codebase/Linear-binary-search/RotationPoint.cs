using System;

class RotationPoint
{
    static void Main()
    {
        int[] arr = { 4, 5, 6, 1, 2, 3 };
        int low = 0, high = arr.Length - 1;

        // Binary search
        while (low < high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] > arr[high])
                low = mid + 1;
            else
                high = mid;
        }

        Console.WriteLine("Rotation Index: " + low);
    }
}
