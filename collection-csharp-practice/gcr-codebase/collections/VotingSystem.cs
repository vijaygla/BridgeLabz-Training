using System;
using System.Collections.Generic;

class VotingSystem
{
    static void Main()
    {
        Dictionary<string, int> votes = new Dictionary<string, int>();
        Queue<string> voteOrder = new Queue<string>();

        CastVote("Alice");
        CastVote("Bob");
        CastVote("Alice");

        SortedDictionary<string, int> sortedResults = new SortedDictionary<string, int>(votes);

        Console.WriteLine("Final Results:");
        foreach (var entry in sortedResults)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }

        void CastVote(string candidate)
        {
            votes[candidate] = votes.GetValueOrDefault(candidate, 0) + 1;
            voteOrder.Enqueue(candidate);
        }
    }
}
