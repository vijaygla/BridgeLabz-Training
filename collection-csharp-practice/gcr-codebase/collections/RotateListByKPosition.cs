using System;
using System.Collections.Generic;

public class RotateListByKPosition
{
    static List<int> RotateList(List<int> list, int k)
    {
        int n = list.Count;
        if (n == 0) return list;

        k = k % n;

        List<int> ans = new List<int>();

        for (int i = k; i < n; i++)
        {
            ans.Add(list[i]);
        }

        for (int i = 0; i < k; i++)
        {
            ans.Add(list[i]);
        }

        return ans;
    }

    // Main method
    static void Main(string[] args)
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
        int k = 2;

        Console.WriteLine("List before rotation:");
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();

        List<int> rotatedList = RotateList(list, k);

        Console.WriteLine("List after rotation:");
        // foreach (var item in rotatedList)
        // {
        //     Console.Write(item + " ");
        // }
        // --------OR----------
        Console.WriteLine(string.Join(" ", list));
    }
}
