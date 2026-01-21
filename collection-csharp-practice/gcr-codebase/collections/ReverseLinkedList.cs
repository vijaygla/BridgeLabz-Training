using System;
using System.Collections;
using System.Collections.Generic;

class ReverseList
{
    // Reverse ArrayList
    static ArrayList ReverseArrayList(ArrayList list)
    {
        ArrayList reversed = new ArrayList();
        for (int i = list.Count - 1; i >= 0; i--)
        {
            reversed.Add(list[i]);
        }
        return reversed;
    }

    // Reverse LinkedList
    static LinkedList<int> ReverseLinkedList(LinkedList<int> list)
    {
        LinkedList<int> reversed = new LinkedList<int>();
        foreach (var item in list)
        {
            reversed.AddFirst(item);
        }
        return reversed;
    }

    // Main method
    static void Main(string[] args)
    {
        // ArrayList example
        ArrayList arrList = new ArrayList() { 10, 20, 30, 40 };
        ArrayList reversedArrayList = ReverseArrayList(arrList);

        Console.WriteLine("Reversed ArrayList:");
        foreach (var item in reversedArrayList)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();

        // LinkedList example
        LinkedList<int> linkedList = new LinkedList<int>();
        linkedList.AddLast(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);
        linkedList.AddLast(4);

        LinkedList<int> reversedLinkedList = ReverseLinkedList(linkedList);

        Console.WriteLine("Reversed LinkedList:");
        foreach (var item in reversedLinkedList)
        {
            Console.Write(item + " ");
        }
    }
}
