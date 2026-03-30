using System;

namespace WordAnalyzerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Utility utility = new Utility();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n====== WORD ANALYZER MENU ======");
                Console.WriteLine("1. Check Reverse and Analyze Words");
                Console.WriteLine("2. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter first word: ");
                        string word1 = Console.ReadLine();

                        Console.Write("Enter second word: ");
                        string word2 = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(word1) || string.IsNullOrWhiteSpace(word2))
                        {
                            Console.WriteLine("❌ Words cannot be empty.");
                        }
                        else
                        {
                            string result = utility.ReverseCheck(word1, word2);
                            Console.WriteLine($"✅ Result: {result}");
                        }
                        break;

                    case "2":
                        exit = true;
                        Console.WriteLine("👋 Exiting application. Thank you!");
                        break;

                    default:
                        Console.WriteLine("❌ Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
