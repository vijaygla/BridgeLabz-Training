class CheckTwoSetsAreEqual
{
    // method to check the sets are equal or not
    static bool AreSetEqual(HashSet<int> set1, HashSet<int> set2)
    {
        return set1.SetEquals(set2);
    }

    // main method
    static void Main(string[] args)
    {
        HashSet<int> set1 = new HashSet<int>(new int[] { 1, 2, 3, 4, 5 });
        HashSet<int> set2 = new HashSet<int>(new int[] { 1, 2, 3, 4, 5 });

        Console.WriteLine($"Both the sets are equal : {AreSetEqual(set1, set2)}");
    }
}
