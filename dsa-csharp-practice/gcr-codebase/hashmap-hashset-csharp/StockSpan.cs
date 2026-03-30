using System;
using System.Collections.Generic;

class StockSpan
{
    static void Main(string[] args)
    {
        int[] price = { 100, 80, 60, 70, 60, 75, 85 };
        int n = price.Length;
        int[] span = new int[n];

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            while (stack.Count > 0 && price[stack.Peek()] <= price[i])
            {
                stack.Pop();
            }

            span[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());
            stack.Push(i);
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(span[i] + " ");
        }

        Console.ReadLine();
    }
}
