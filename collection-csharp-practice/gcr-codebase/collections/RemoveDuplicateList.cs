using System.Runtime.InteropServices.Marshalling;

class RemoveDuplicateList
{
    // method to remove duplicate
    static List<int> RemoveDuplicateFromList(List<int> list)
    {
        List<int> ans = new List<int>();
        foreach(var item in list)
        {
            if(!ans.Contains(item))
            {
                ans.Add(item);
            }
        }
        return ans;
    }
    static void Main(String[] args)
    {
        List<int> list = new List<int>() {1, 2, 3, 2, 1, 5};
        Console.WriteLine("List before remove duplicate:");
        Console.WriteLine(string.Join(" ", list));

        List<int> removedDuplicate = RemoveDuplicateFromList(list);
        Console.WriteLine("List after remove duplicate:");
        Console.WriteLine(string.Join(" ", removedDuplicate));
    }
}
