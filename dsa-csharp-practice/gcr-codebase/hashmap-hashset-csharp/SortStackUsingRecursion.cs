using System;
using System.Collections.Generic;

class SortStackUsingRecursion
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(3);
        stack.Push(1);
        stack.Push(4);
        stack.Push(2);

        SortStack(stack);

        while (stack.Count > 0)
        {
            Console.Write(stack.Pop() + " ");
        }

        Console.ReadLine();
    }

    static void SortStack(Stack<int> stack)
    {
        if (stack.Count > 0)
        {
            int temp = stack.Pop();
            SortStack(stack);
            InsertSorted(stack, temp);
        }
    }

    static void InsertSorted(Stack<int> stack, int value)
    {
        if (stack.Count == 0 || stack.Peek() <= value)
        {
            stack.Push(value);
            return;
        }

        int temp = stack.Pop();
        InsertSorted(stack, value);
        stack.Push(temp);
    }
}
