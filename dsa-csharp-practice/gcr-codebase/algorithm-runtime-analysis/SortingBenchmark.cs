using System;
using System.Diagnostics;
using System.Linq;

class SortingBenchmark
{
    // Time: Bubble O(N^2), Merge/Quick O(N log N) avg | Space: Bubble O(1), Merge O(N), Quick O(log N)
    static void Main()
    {
        int[] sizes = { 1000, 10000 };

        foreach (int n in sizes)
        {
            // FIX: C# 5 compatible descending data
            int[] data = Enumerable.Range(1, n).Reverse().ToArray();
            int[] arr;

            // Bubble Sort
            arr = (int[])data.Clone();
            var sw = Stopwatch.StartNew();
            BubbleSort(arr);
            sw.Stop();
            Console.WriteLine("Bubble N=" + n + ": " + sw.ElapsedMilliseconds + "ms");

            // Merge Sort
            arr = (int[])data.Clone();
            sw.Restart();
            MergeSort(arr, 0, arr.Length - 1);
            sw.Stop();
            Console.WriteLine("Merge N=" + n + ": " + sw.ElapsedMilliseconds + "ms");

            // Quick Sort
            arr = (int[])data.Clone();
            sw.Restart();
            QuickSort(arr, 0, arr.Length - 1);
            sw.Stop();
            Console.WriteLine("Quick N=" + n + ": " + sw.ElapsedMilliseconds + "ms");
        }

        Console.WriteLine("Time Complexity: Bubble O(N^2), Merge/Quick O(N log N) | Space: Varies O(1)-O(N)");
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
    }

    static void MergeSort(int[] arr, int l, int r)
    {
        if (l < r)
        {
            int m = l + (r - l) / 2;
            MergeSort(arr, l, m);
            MergeSort(arr, m + 1, r);
            Merge(arr, l, m, r);
        }
    }

    static void Merge(int[] arr, int l, int m, int r)
    {
        int n1 = m - l + 1, n2 = r - m;
        int[] L = new int[n1];
        int[] R = new int[n2];

        Array.Copy(arr, l, L, 0, n1);
        Array.Copy(arr, m + 1, R, 0, n2);

        int i = 0, j = 0, k = l;
        while (i < n1 && j < n2)
            arr[k++] = (L[i] <= R[j]) ? L[i++] : R[j++];

        while (i < n1) arr[k++] = L[i++];
        while (j < n2) arr[k++] = R[j++];
    }

    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

        int temp2 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp2;

        return i + 1;
    }
}
