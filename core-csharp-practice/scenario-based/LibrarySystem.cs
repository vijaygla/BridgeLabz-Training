using System;

class LibrarySystem
{
    static string[] titles =
    {
        "C Programming",
        "Java Basics",
        "Data Structures",
        "Operating Systems",
        "Computer Networks"
    };

    static string[] authors =
    {
        "Dennis Ritchie",
        "James Gosling",
        "Mark Allen",
        "Andrew Tanenbaum",
        "Forouzan"
    };

    static bool[] isAvailable =
    {
        true, true, true, true, true
    };

    // Display all books
    static void DisplayBooks()
    {
        Console.WriteLine("\nLibrary Books:");
        for (int i = 0; i < titles.Length; i++)
        {
            Console.WriteLine(
                titles[i] + " | " +
                authors[i] + " | " +
                (isAvailable[i] ? "Available" : "Checked Out")
            );
        }
    }

    // Search book by partial title
    static void SearchBook(string keyword)
    {
        Console.WriteLine("\nSearch Results:");
        for (int i = 0; i < titles.Length; i++)
        {
            if (IsPartialMatch(titles[i], keyword))
            {
                Console.WriteLine(
                    titles[i] + " | " +
                    authors[i] + " | " +
                    (isAvailable[i] ? "Available" : "Checked Out")
                );
            }
        }
    }

    // Custom partial string matching method
    static bool IsPartialMatch(string text, string pattern)
    {
        for (int i = 0; i <= text.Length - pattern.Length; i++)
        {
            int j;
            for (j = 0; j < pattern.Length; j++)
            {
                if (text[i + j] != pattern[j])
                    break;
            }

            if (j == pattern.Length)
                return true;
        }
        return false;
    }

    // Checkout a book if available than checkout
    static void CheckoutBook(string title)
    {
        for (int i = 0; i < titles.Length; i++)
        {
            if (titles[i] == title)
            {
                if (isAvailable[i])
                {
                    isAvailable[i] = false;
                    Console.WriteLine("Book checked out successfully.");
                }
                else
                {
                    Console.WriteLine("Book already checked out.");
                }
                return;
            }
        }
        Console.WriteLine("Book not found.");
    }

    static void Main()
    {
        DisplayBooks();

        Console.Write("\nEnter keyword to search book: ");
        string keyword = Console.ReadLine();
        SearchBook(keyword);

        Console.Write("\nEnter exact book title to checkout: ");
        string bookTitle = Console.ReadLine();
        CheckoutBook(bookTitle);

        DisplayBooks();
    }
}
