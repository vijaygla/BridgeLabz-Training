using System;
using System.Diagnostics;
using System.Reflection;

class Worker
{
    public void DoWork()
    {
        for (int i = 0; i < 1000000; i++) { }
    }
}

class MethodExecutionTimer
{
    static void Main()
    {
        // Main purpose:
        // Measure execution time of methods using Reflection

        Worker worker = new Worker();
        MethodInfo method = typeof(Worker).GetMethod("DoWork");

        Stopwatch sw = Stopwatch.StartNew();
        method.Invoke(worker, null);
        sw.Stop();

        Console.WriteLine("Execution Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
