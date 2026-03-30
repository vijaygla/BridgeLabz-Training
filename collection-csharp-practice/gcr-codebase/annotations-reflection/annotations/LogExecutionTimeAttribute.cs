using System;
using System.Diagnostics;

[AttributeUsage(AttributeTargets.Method)]
class LogExecutionTimeAttribute : Attribute { }

class Worker
{
    [LogExecutionTime]
    public void DoWork()
    {
        System.Threading.Thread.Sleep(500);
    }
}

class Program
{
    static void Main()
    {
        Worker w = new Worker();
        Stopwatch sw = Stopwatch.StartNew();
        w.DoWork();
        sw.Stop();

        Console.WriteLine($"Execution Time: {sw.ElapsedMilliseconds} ms");
    }
}
