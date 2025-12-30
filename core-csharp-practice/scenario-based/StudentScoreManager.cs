using System;

class StudentScoreManager
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        float[] scores = new float[n];
        float sum = 0;

        // Input student scores with validation
        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                Console.Write("Enter score for student " + (i + 1) + ": ");
                string input = Console.ReadLine();

                float score; // Declare variable separately (IMPORTANT)

                // TryParse without inline out variable
                bool isNumber = float.TryParse(input, out score);

                if (!isNumber || score < 0)
                {
                    Console.WriteLine("Invalid input! Enter a non-negative numeric value.");
                }
                else
                {
                    scores[i] = score;
                    sum += score;
                    break;
                }
            }
        }

        // Calculate average score
        float average = sum / n;

        // Initialize highest and lowest scores
        float highest = scores[0];
        float lowest = scores[0];

        // Find highest and lowest score
        for (int i = 1; i < n; i++)
        {
            if (scores[i] > highest)
            {
                highest = scores[i];
            }

            if (scores[i] < lowest)
            {
                lowest = scores[i];
            }
        }

        // Display results
        Console.WriteLine("\nAverage Score: " + average);
        Console.WriteLine("Highest Score: " + highest);
        Console.WriteLine("Lowest Score: " + lowest);

        // Display scores above average
        Console.WriteLine("\nScores Above Average:");
        for (int i = 0; i < n; i++)
        {
            if (scores[i] > average)
            {
                Console.WriteLine(scores[i]);
            }
        }
    }
}
