using System;

class ProcessNode
{
    public int ProcessId;
    public int BurstTime;
    public int RemainingTime;
    public int Priority;

    public ProcessNode Next;

    public ProcessNode(int id, int burst, int priority)
    {
        ProcessId = id;
        BurstTime = burst;
        RemainingTime = burst;
        Priority = priority;
        Next = null;
    }
}

class RoundRobinScheduler
{
    private ProcessNode head;

    public void AddProcess(int id, int burst, int priority)
    {
        ProcessNode newNode = new ProcessNode(id, burst, priority);

        if (head == null)
        {
            head = newNode;
            newNode.Next = head;
            return;
        }

        ProcessNode temp = head;
        while (temp.Next != head)
        {
            temp = temp.Next;
        }

        temp.Next = newNode;
        newNode.Next = head;
    }

    public void Simulate(int timeQuantum)
    {
        if (head == null)
        {
            Console.WriteLine("No processes available");
            return;
        }

        int time = 0;
        int totalWaiting = 0;
        int totalTurnaround = 0;
        int count = CountProcesses();

        ProcessNode temp = head;

        while (count > 0)
        {
            if (temp.RemainingTime > 0)
            {
                int execute = temp.RemainingTime > timeQuantum ? timeQuantum : temp.RemainingTime;
                temp.RemainingTime -= execute;
                time += execute;

                DisplayProcesses();

                if (temp.RemainingTime == 0)
                {
                    totalTurnaround += time;
                    totalWaiting += time - temp.BurstTime;
                    count--;
                }
            }
            temp = temp.Next;
        }

        Console.WriteLine("Average Waiting Time: " + (double)totalWaiting / CountOriginal());
        Console.WriteLine("Average Turnaround Time: " + (double)totalTurnaround / CountOriginal());
    }

    private int CountProcesses()
    {
        int count = 0;
        ProcessNode temp = head;
        do
        {
            if (temp.RemainingTime > 0)
                count++;
            temp = temp.Next;
        } while (temp != head);
        return count;
    }

    private int CountOriginal()
    {
        int count = 0;
        ProcessNode temp = head;
        do
        {
            count++;
            temp = temp.Next;
        } while (temp != head);
        return count;
    }

    public void DisplayProcesses()
    {
        ProcessNode temp = head;
        Console.WriteLine("Current Queue:");
        do
        {
            Console.WriteLine("Process " + temp.ProcessId + " Remaining: " + temp.RemainingTime);
            temp = temp.Next;
        } while (temp != head);
        Console.WriteLine();
    }
}

class RoundRobinSchedulingAlgorithm
{
    static void Main()
    {
        RoundRobinScheduler rr = new RoundRobinScheduler();
        rr.AddProcess(1, 10, 1);
        rr.AddProcess(2, 5, 2);
        rr.AddProcess(3, 8, 1);

        rr.Simulate(3);
    }
}
