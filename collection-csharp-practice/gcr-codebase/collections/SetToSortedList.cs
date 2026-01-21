using System;
using System.Collections.Generic;

class SetToSortedList
{
    static void Main()
    {
        HashSet<int> set = new HashSet<int> { 5, 3, 9, 1 };

        // Convert HashSet to List
        List<int> sortedList = new List<int>(set);

        // Sort the list in ascending order
        sortedList.Sort();

        Console.WriteLine("Sorted List: " + string.Join(", ", sortedList));
    }
}
