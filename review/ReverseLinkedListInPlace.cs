using System;

class ListNode
{
    public int Data;
    public ListNode Next;

    public ListNode(int data)
    {
        Data = data;
        Next = null;
    }
}

class ReverseLinkedList
{
    public static int CountNode(ListNode head)
    {
        int count = 0;
        ListNode curr = head;
        while (curr != null)
        {
            count++;
            curr = curr.Next;
        }
        return count;
    }

    public static void Display(ListNode head)
    {
        ListNode curr = head;
        while (curr != null)
        {
            Console.Write(curr.Data);
            if (curr.Next != null)
                Console.Write(" ---> ");
            curr = curr.Next;
        }
        Console.WriteLine();
    }

    public static ListNode ReverseLinkedListInPlace(ListNode head, int[] nums)
    {
        // node data into array
        int firstIndex = 0;
        ListNode curr = head;
        while (curr != null)
        {
            nums[firstIndex++] = curr.Data;
            curr = curr.Next;
        }

        // reverse
        curr = head;
        int lastIndex = nums.Length - 1;
        while (curr != null)
        {
            curr.Data = nums[lastIndex--];
            curr = curr.Next;
        }

        return head;
    }

    static void Main(string[] args)
    {
        ListNode head = new ListNode(10);
        head.Next = new ListNode(20);
        head.Next.Next = new ListNode(30);
        head.Next.Next.Next = new ListNode(40);
        head.Next.Next.Next.Next = new ListNode(50);

        int n = CountNode(head);
        Console.WriteLine($"Count of Node : {n}");

        Console.Write("Print the LinkedList before reverse: ");
        Display(head);

        int[] nums = new int[n];

        ListNode newNode = ReverseLinkedListInPlace(head, nums);

        Console.Write("Print the LinkedList  after reverse: ");
        Display(newNode);
    }
}
