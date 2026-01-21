class ReverseQueue
{
    static void Main()
    {
        Queue<int> q = new Queue<int>();
        q.Enqueue(10);
        q.Enqueue(20);
        q.Enqueue(30);
        q.Enqueue(40);

        // reverse using built in stack
        Stack<int> stack = new Stack<int>(q);
        q.Clear();

        while(stack.Count > 0)
        {
            q.Enqueue(stack.Pop());
        }

        Console.WriteLine("Reversed Queue : " + string.Join(", ", q));
    }
}
