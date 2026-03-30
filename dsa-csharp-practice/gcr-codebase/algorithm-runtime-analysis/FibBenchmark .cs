using System;
using System.Diagnostics;

class FibBenchmark {
    // Time: Recursive O(2^N) exponential, Iterative O(N) | Space: Recursive O(N) stack, Iterative O(1)
    static void Main() {
        int[] ns = {10, 30, 40};
        foreach (int n in ns) {
            // Recursive
            var sw = Stopwatch.StartNew();
            long rec = FibonacciRecursive(n);
            sw.Stop();
            Console.WriteLine("Recursive Fib(" + n + "): " + sw.ElapsedMilliseconds + "ms");

            // Iterative
            sw.Restart();
            long iter = FibonacciIterative(n);
            sw.Stop();
            Console.WriteLine("Iterative Fib(" + n + "): " + sw.ElapsedMilliseconds + "ms");
        }
        Console.WriteLine("Time Complexity: Recursive O(2^N), Iterative O(N) | Space: O(N)/O(1)");
    }

    static long FibonacciRecursive(int n) {
        // Time O(2^N), Space O(N) call stack
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    static long FibonacciIterative(int n) {
        // Time O(N), Space O(1)
        if (n <= 1) return n;
        long a = 0, b = 1;
        for (int i = 2; i <= n; i++) {
            long sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }
}
