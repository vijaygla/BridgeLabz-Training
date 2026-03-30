using System;

class EduQuiz
{
    // data is hidden usinh the incapsulation
    private string[] questions =
    {
        "What is the capital of India?",
        "Which language is used for Android development?",
        "Which keyword is used to create object in C#?",
        "Which data type holds decimal values?",
        "What does OOP stand for?",
        "Which company developed C#?",
        "Which symbol is used for single-line comment in C#?",
        "Which loop executes at least once?",
        "What is the file extension of C#?",
        "Which access modifier makes members accessible everywhere?"
    };

    private string[] correctAnswers =
    {
        "Delhi",
        "Java",
        "new",
        "float",
        "Object Oriented Programming",
        "Microsoft",
        "//",
        "do-while",
        ".cs",
        "public"
    };

    private string[] studentAnswers = new string[10];

    // Case-insensitive string comparison (custom)
    private bool IsEqualIgnoreCase(string s1, string s2)
    {
        if (s1.Length != s2.Length)
            return false;

        for (int i = 0; i < s1.Length; i++)
        {
            char c1 = s1[i];
            char c2 = s2[i];

            if (c1 >= 'A' && c1 <= 'Z')
                c1 = (char)(c1 + 32);

            if (c2 >= 'A' && c2 <= 'Z')
                c2 = (char)(c2 + 32);

            if (c1 != c2)
                return false;
        }
        return true;
    }

    // Calculate score and show feedback
    private int CalculateScore(string[] correct, string[] student)
    {
        int score = 0;

        Console.WriteLine("\n--- Quiz Feedback ---");
        for (int i = 0; i < correct.Length; i++)
        {
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

    public void StartQuiz()
    {
        Console.WriteLine("===== Welcome to EduQuiz =====\n");

        // Display questions and take answers
        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine("Q" + (i + 1) + ": " + questions[i]);
            Console.Write("Your Answer: ");
            studentAnswers[i] = Console.ReadLine();
            Console.WriteLine();
        }

        int score = CalculateScore(correctAnswers, studentAnswers);

        int percentage = (score * 100) / questions.Length;

        Console.WriteLine("\nTotal Score: " + score + "/" + questions.Length);
        Console.WriteLine("Percentage: " + percentage + "%");

        if (percentage >= 50)
            Console.WriteLine("Result: PASS");
        else
            Console.WriteLine("Result: FAIL");
    }
}


class Program
{
    static void Main()
    {
        EduQuiz quiz = new EduQuiz();
        quiz.StartQuiz();   // Student cannot access data directly
    }
}
