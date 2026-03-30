using System;
using System.Diagnostics;
using System.Linq;

class SearchBenchmark {
    // Time: Linear O(N), Space O(1) | Binary O(log N) search after O(N log N) sort, Space O(1) iterative
    static void Main() {
        int[] sizes = {1000, 10000, 1000000};
        int target = 500000;
        foreach (int n in sizes) {
            int[] data = Enumerable.Range(1, n).ToArray();
            // Linear Search
            var sw = Stopwatch.StartNew();
            int linearResult = LinearSearch(data, target);
            sw.Stop();
            Console.WriteLine("Linear N=" + n + ": " + sw.ElapsedMilliseconds + "ms");

            // Binary Search
            sw.Restart();
            int binaryResult = BinarySearch(data, target);
            sw.Stop();
            Console.WriteLine("Binary N=" + n + ": " + sw.ElapsedMilliseconds + "ms");
        }
        Console.WriteLine("Time Complexity: Linear O(N), Binary O(log N) | Space: O(1)");
    }

    static int LinearSearch(int[] arr, int target) {
        // Time O(N), Space O(1)
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] == target) return i;
        }
        return -1;
    }

    static int BinarySearch(int[] arr, int target) {
        // Time O(log N), Space O(1)
        int low = 0, high = arr.Length - 1;
        while (low <= high) {
            int mid = low + (high - low) / 2;
            if (arr[mid] == target) return mid;
            if (arr[mid] < target) low = mid + 1;
            else high = mid - 1;
        }
        return -1;
    }
}
