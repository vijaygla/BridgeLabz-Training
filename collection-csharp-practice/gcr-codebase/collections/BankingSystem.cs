using System;
using System.Collections.Generic;

class BankingSystem
{
    static void Main()
    {
        Dictionary<int, double> accounts = new Dictionary<int, double>
        {
            { 101, 5000 },
            { 102, 12000 },
            { 103, 8000 }
        };

        SortedDictionary<double, int> sortedByBalance = new SortedDictionary<double, int>();
        Queue<int> withdrawalQueue = new Queue<int>();

        foreach (var acc in accounts)
        {
            sortedByBalance[acc.Value] = acc.Key;
        }

        withdrawalQueue.Enqueue(101);
        withdrawalQueue.Enqueue(103);

        Console.WriteLine("Processing Withdrawals:");
        while (withdrawalQueue.Count > 0)
        {
            Console.WriteLine($"Processing account: {withdrawalQueue.Dequeue()}");
        }
    }
}
