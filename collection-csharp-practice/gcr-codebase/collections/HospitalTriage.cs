using System;
using System.Collections.Generic;

class HospitalTriage
{
    static void Main()
    {
        // Higher severity = higher priority
        PriorityQueue<string, int> patients = new PriorityQueue<string, int>();

        patients.Enqueue("John", -3);
        patients.Enqueue("Alice", -5);
        patients.Enqueue("Bob", -2);

        Console.WriteLine("Treatment Order:");
        while (patients.Count > 0)
        {
            Console.WriteLine(patients.Dequeue());
        }
    }
}
