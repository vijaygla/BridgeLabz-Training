using System;

class FestivalLuckyDraw
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Festival Lucky Draw ===");

        while (true)
        {
            // Ask visitor to enter number
            Console.Write("Enter lucky draw number (or type exit to stop): ");
            string input = Console.ReadLine();

            // Exit condition
            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Lucky Draw program ended.");
                break;
            }

            int number;
            bool isValid = int.TryParse(input, out number);

            // Invalid input handling
            if (!isValid || number <= 0)
            {
                Console.WriteLine("Invalid input. Visitor skipped.");
                continue;
            }

            // Check lucky draw condition
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("🎉 Congratulations! You won a gift!");
            }
            else
            {
                Console.WriteLine("Sorry, no gift this time.");
            }
        }
    }
}
