using System;
using System.Diagnostics;
using System.Text;

class StringBenchmark {
    // Time: string O(N^2) immutable copies, StringBuilder O(N) | Space: O(N) both
    static void Main() {
        int[] sizes = {1000, 10000, 100000};
        foreach (int n in sizes) {
            // string
            var sw = Stopwatch.StartNew();
            string result = "";
            for (int i = 0; i < n; i++) {
                result = result + i + " ";
            }
            sw.Stop();
            Console.WriteLine("string N=" + n + ": " + sw.ElapsedMilliseconds + "ms");

            // StringBuilder
            sw.Restart();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++) {
                sb.Append(i + " ");
            }
            string final = sb.ToString();
            sw.Stop();
            Console.WriteLine("StringBuilder N=" + n + ": " + sw.ElapsedMilliseconds + "ms");
        }
        Console.WriteLine("Time Complexity: string O(N^2), StringBuilder O(N) | Space: O(N)");
    }
}
