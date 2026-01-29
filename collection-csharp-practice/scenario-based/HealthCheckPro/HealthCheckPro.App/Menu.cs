using System;
using HealthCheckPro.Core.Scanner;

namespace HealthCheckPro.App
{
    public static class Menu
    {
        public static void Show()
        {
            while (true)
            {
                Console.WriteLine("\n=== HealthCheckPro – API Metadata Validator ===");
                Console.WriteLine("1. Scan APIs & Generate Documentation");
                Console.WriteLine("2. Exit");
                Console.Write("Enter choice: ");

                var choice = Console.ReadLine() ?? string.Empty;

                switch (choice)
                {
                    case "1":
                        ApiMetadataScanner.ScanAndGenerateDocs();
                        break;
                    case "2":
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}
