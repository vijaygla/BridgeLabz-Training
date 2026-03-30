using System;

class Library
{
    // Book data hidden using encapsulation
    private string[] titles =
    {
        "C Programming",
        "Java Basics",
        "Data Structures",
        "Operating Systems",
        "Computer Networks"
    };

    private string[] authors =
    {
        "Dennis Ritchie",
        "James Gosling",
        "Mark Allen",
        "Andrew Tanenbaum",
        "Forouzan"
    };

    private bool[] isAvailable =
    {
        true, true, true, true, true
    };

    // Display all books
    public void DisplayBooks()
    {
        Console.WriteLine("\n--- Library Books ---");
        for (int i = 0; i < titles.Length; i++)
        {
            Console.WriteLine(
                (i + 1) + ". " +
                titles[i] + " | " +
                authors[i] + " | " +
                (isAvailable[i] ? "Available" : "Checked Out")
            );
        }
    }

    // Search book by partial title (case-insensitive)
    public void SearchBook(string keyword)
    {
        Console.WriteLine("\n--- Search Results ---");
        for (int i = 0; i < titles.Length; i++)
        {
            if (titles[i].IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                Console.WriteLine(
                    titles[i] + " | " +
                    authors[i] + " | " +
                    (isAvailable[i] ? "Available" : "Checked Out")
                );
            }
        }
    }

    // Checkout book (User action)
    public void CheckoutBook(string title)
    {
        for (int i = 0; i < titles.Length; i++)
        {
            if (titles[i].Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                if (isAvailable[i])
                {
                    isAvailable[i] = false;
                    Console.WriteLine("Book checked out successfully.");
                }
                else
                {
                    Console.WriteLine("Book is already checked out.");
                }
                return;
            }
        }
        Console.WriteLine("Book not found.");
    }

    // Admin updates book status
    public void UpdateBookStatus(int index, bool status)
    {
        if (index >= 0 && index < isAvailable.Length)
        {
            isAvailable[index] = status;
            Console.WriteLine("Book status updated successfully.");
        }
        else
        {
            Console.WriteLine("Invalid book selection.");
        }
    }
}


// admin class
static class Admin
{
    // Static admin method - one object will create for this method
    public static void AdminMenu(Library library)
    {
        library.DisplayBooks();

        Console.Write("\nEnter book number to change status: ");
        int bookNo = int.Parse(Console.ReadLine());

        Console.Write("Enter status (true = Available / false = Checked Out): ");
        bool status = bool.Parse(Console.ReadLine());

        library.UpdateBookStatus(bookNo - 1, status);
    }
}


// user class
class User
{
    private Library library;

    public User(Library lib)
    {
        library = lib;
    }

    public void UserMenu()
    {
        library.DisplayBooks();

        Console.Write("\nEnter keyword to search book: ");
        string keyword = Console.ReadLine();
        library.SearchBook(keyword);

        Console.Write("\nEnter exact book title to checkout: ");
        string title = Console.ReadLine();
        library.CheckoutBook(title);
    }
}


// program class which contain the main method
class Program
{
    static void Main()
    {
        Library library = new Library();

        Console.WriteLine("===== Library Management System =====");
        Console.WriteLine("1. Admin");
        Console.WriteLine("2. User");
        Console.Write("Select role: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            // Admin accessed statically
            Admin.AdminMenu(library);
        }
        else if (choice == 2)
        {
            User user = new User(library);
            user.UserMenu();
        }
        else
        {
            Console.WriteLine("Invalid option.");
        }

        // Final state of library
        library.DisplayBooks();
    }
}
