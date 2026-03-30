using System.Reflection.Metadata;

class SymmetricDifference
{
    static void Main(String[] args)
    {
        HashSet<int> set1 = new HashSet<int> {1, 2, 3};
        HashSet<int> set2 = new HashSet<int> {5, 6, 3};

        // symmetric differnce
        HashSet<int> symmetricDiff = new HashSet<int>(set1);
        symmetricDiff.SymmetricExceptWith(set2);

        Console.WriteLine("Symmetric Difference : " + string.Join(" ", symmetricDiff));
    }
}
