using System;
using IPLCensorshipAnalyzer.Processors;

namespace IPLCensorshipAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IPL Censorship Analyzer");
            Console.WriteLine("======================");

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Process CSV file");
                Console.WriteLine("2. Process JSON file");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice (1-3): ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        IplCsvProcessor.ProcessCsv();
                        break;
                    case "2":
                        IplJsonProcessor.ProcessJson();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
