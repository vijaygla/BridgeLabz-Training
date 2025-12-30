using System;

class EduQuiz
{
    // Method to compare answers and calculate score
    static int CalculateScore(string[] correct, string[] student)
    {
        int score = 0;

        for (int i = 0; i < correct.Length; i++)
        {
            // Compare answers using custom case-insensitive method
            if (IsEqualIgnoreCase(correct[i], student[i]))
            {
                Console.WriteLine("Question " + (i + 1) + ": Correct");
                score++;
            }
            else
            {
                Console.WriteLine("Question " + (i + 1) + ": Incorrect");
            }
        }

        return score;
    }

    // Custom method for case-insensitive string comparison
    static bool IsEqualIgnoreCase(string s1, string s2)
    {
        if (s1.Length != s2.Length)
            return false;

        for (int i = 0; i < s1.Length; i++)
        {
            char c1 = s1[i];
            char c2 = s2[i];

            // Convert uppercase to lowercase manually
            if (c1 >= 'A' && c1 <= 'Z')
                c1 = (char)(c1 + 32);

            if (c2 >= 'A' && c2 <= 'Z')
                c2 = (char)(c2 + 32);

            if (c1 != c2)
                return false;
        }

        return true;
    }

    static void Main()
    {
        string[] correctAnswers =
        {
            "A","B","C","D","A","C","B","D","A","B"
        };

        string[] studentAnswers = new string[10];

        // Input student answers
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Select option(a, b, c, d) for Question " + (i + 1) + ": ");
            studentAnswers[i] = Console.ReadLine();
        }

        int score = CalculateScore(correctAnswers, studentAnswers);

        // Calculate percentage
        int percentage = (score * 100) / 10;

        Console.WriteLine("\nTotal Score: " + score + "/10");
        Console.WriteLine("Percentage: " + percentage + "%");

        // Pass / Fail
        if (percentage >= 50)
            Console.WriteLine("Result: PASS");
        else
            Console.WriteLine("Result: FAIL");
    }
}

