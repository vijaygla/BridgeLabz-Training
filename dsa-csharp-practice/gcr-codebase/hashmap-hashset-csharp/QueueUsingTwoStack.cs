using System;
using System.Collections.Generic;

class QueueUsingTwoStacks
{
    static Stack<int> stack1 = new Stack<int>();
    static Stack<int> stack2 = new Stack<int>();

    static void Main(string[] args)
    {
        Enqueue(10);
        Enqueue(20);
        Enqueue(30);

        Console.WriteLine("Dequeued: " + Dequeue());
        Console.WriteLine("Dequeued: " + Dequeue());

        Console.ReadLine();
    }

    static void Enqueue(int value)
    {
        stack1.Push(value);
    }

    static int Dequeue()
    {
        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }

        if (stack2.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return -1;
        }

        return stack2.Pop();
    }
}
