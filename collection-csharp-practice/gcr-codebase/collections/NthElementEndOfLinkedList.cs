class NthElemnetEndOfLinkedList
{
    // method to print the nth character from the end of linked list
    static char FindNthFromEnd(LinkedList<char> list, int k)
    {
        LinkedList<char> reversedList = new LinkedList<char>(list.Reverse());

        var desiredNode = reversedList.First;

        for (int i = 1; i < k; i++)
        {
            desiredNode = desiredNode.Next;
        }

        return desiredNode.Value;
    }

    // main method
    static void Main(string[] args)
    {
        LinkedList<char> list = new LinkedList<char>(new char[] { 'v', 'i', 'j', 'a', 'y' });
        int k = 2;

        char ans = FindNthFromEnd(list, k);
        Console.WriteLine($"Nth node from the end : {ans}");
    }
}
