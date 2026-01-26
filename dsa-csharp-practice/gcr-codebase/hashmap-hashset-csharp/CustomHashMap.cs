using System;

class CustomHashMap
{
    class Node
    {
        public int key;
        public int value;
        public Node next;

        public Node(int k, int v)
        {
            key = k;
            value = v;
        }
    }

    static Node[] table = new Node[10];

    static void Main(string[] args)
    {
        Put(1, 10);
        Put(2, 20);
        Put(12, 30);

        Console.WriteLine("Value for key 2: " + Get(2));

        Remove(2);
        Console.WriteLine("Value for key 2 after removal: " + Get(2));

        Console.ReadLine();
    }

    static void Put(int key, int value)
    {
        int index = key % table.Length;
        Node node = new Node(key, value);
        node.next = table[index];
        table[index] = node;
    }

    static int Get(int key)
    {
        int index = key % table.Length;
        Node current = table[index];

        while (current != null)
        {
            if (current.key == key)
            {
                return current.value;
            }
            current = current.next;
        }
        return -1;
    }

    static void Remove(int key)
    {
        int index = key % table.Length;
        Node current = table[index];
        Node prev = null;

        while (current != null)
        {
            if (current.key == key)
            {
                if (prev == null)
                {
                    table[index] = current.next;
                }
                else
                {
                    prev.next = current.next;
                }
                return;
            }
            prev = current;
            current = current.next;
        }
    }
}
