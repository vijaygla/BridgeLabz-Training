using System;
using System.Collections.Generic;

class CheckSubset
{
    static void Main()
    {
        HashSet<int> subset = new HashSet<int> { 2, 3 };
        HashSet<int> mainSet = new HashSet<int> { 1, 2, 3, 4 };

        // Check if subset is contained in mainSet
        bool isSubset = subset.IsSubsetOf(mainSet);

        Console.WriteLine("Is Subset : " + isSubset); // Output: true
    }
}
