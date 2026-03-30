using System;
using System.IO;
using IPLCensorshipAnalyzer.Utilities;

namespace IPLCensorshipAnalyzer.Processors
{
    public class IplCsvProcessor
    {
        public static void ProcessCsv()
        {
            try
            {
                string csvPath = Path.Combine("Data", "ipl.csv");
                string censoredCsvPath = Path.Combine("Data", "ipl_censored.csv");

                if (!File.Exists(csvPath))
                {
                    Console.WriteLine($"Error: File not found at {csvPath}");
                    return;
                }

                var lines = File.ReadAllLines(csvPath);
                using var sw = new StreamWriter(censoredCsvPath);

                sw.WriteLine(lines[0]);

                for (int i = 1; i < lines.Length; i++)
                {
                    var p = lines[i].Split(',');

                    p[1] = MaskingUtility.MaskTeamName(p[1]);
                    p[2] = MaskingUtility.MaskTeamName(p[2]);
                    p[5] = MaskingUtility.MaskTeamName(p[5]);
                    p[6] = "REDACTED";

                    sw.WriteLine(string.Join(",", p));
                }
                Console.WriteLine("CSV processing complete.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during CSV processing: {ex.Message}");
            }
        }
    }
}
