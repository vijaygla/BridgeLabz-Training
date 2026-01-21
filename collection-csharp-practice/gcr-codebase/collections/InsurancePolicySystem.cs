using System;
using System.Collections.Generic;
using System.Linq;

class InsurancePolicySystem
{
    static void Main()
    {
        HashSet<string> uniquePolicies = new HashSet<string>();
        LinkedList<string> insertionOrder = new LinkedList<string>();

        SortedSet<(DateTime expiry, string policy)> sortedPolicies =
            new SortedSet<(DateTime, string)>();

        AddPolicy("P101", DateTime.Now.AddDays(20));
        AddPolicy("P102", DateTime.Now.AddDays(60));
        AddPolicy("P103", DateTime.Now.AddDays(10));

        Console.WriteLine("Policies expiring in 30 days:");
        foreach (var p in sortedPolicies.Where(p => (p.expiry - DateTime.Now).Days <= 30))
        {
            Console.WriteLine(p.policy);
        }

        void AddPolicy(string policyNo, DateTime expiry)
        {
            if (uniquePolicies.Add(policyNo))
            {
                insertionOrder.AddLast(policyNo);
                sortedPolicies.Add((expiry, policyNo));
            }
        }
    }
}
