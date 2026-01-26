using System;

// Node class
class BookNode
{
    public int BookId;
    public string Title;
    public string Author;
    public string Genre;
    public bool IsAvailable;

    public BookNode Prev;
    public BookNode Next;

    public BookNode(int bookId, string title, string author, string genre, bool isAvailable)
    {
        BookId = bookId;
        Title = title;
        Author = author;
        Genre = genre;
        IsAvailable = isAvailable;
        Prev = null;
        Next = null;
    }
}

// Doubly Linked List class
class LibraryDoublyLinkedList
{
    private BookNode head;
    private BookNode tail;

    // Add at beginning
    public void AddAtBeginning(int id, string title, string author, string genre, bool available)
    {
        BookNode newNode = new BookNode(id, title, author, genre, available);

        if (head == null)
        {
            head = tail = newNode;
            return;
        }

        newNode.Next = head;
        head.Prev = newNode;
        head = newNode;
    }

    // Add at end
    public void AddAtEnd(int id, string title, string author, string genre, bool available)
    {
        BookNode newNode = new BookNode(id, title, author, genre, available);

        if (tail == null)
        {
            head = tail = newNode;
            return;
        }

        tail.Next = newNode;
        newNode.Prev = tail;
        tail = newNode;
    }

    // Add at specific position (1-based)
    public void AddAtPosition(int position, int id, string title, string author, string genre, bool available)
    {
        if (position <= 0)
        {
            Console.WriteLine("Invalid position");
            return;
        }

        if (position == 1)
        {
            AddAtBeginning(id, title, author, genre, available);
            return;
        }

        BookNode temp = head;
        for (int i = 1; i < position - 1 && temp != null; i++)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Position out of range");
            return;
        }

        BookNode newNode = new BookNode(id, title, author, genre, available);
        newNode.Next = temp.Next;
        newNode.Prev = temp;

        if (temp.Next != null)
        {
            temp.Next.Prev = newNode;
        }
        else
        {
            tail = newNode;
        }

        temp.Next = newNode;
    }

    // Remove by Book ID
    public void RemoveByBookId(int id)
    {
        BookNode temp = head;

        while (temp != null)
        {
            if (temp.BookId == id)
            {
                if (temp == head)
                {
                    head = temp.Next;
                    if (head != null)
                        head.Prev = null;
                }
                else if (temp == tail)
                {
                    tail = temp.Prev;
                    tail.Next = null;
                }
                else
                {
                    temp.Prev.Next = temp.Next;
                    temp.Next.Prev = temp.Prev;
                }

                Console.WriteLine("Book removed");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Book not found");
    }

    // Search by Title
    public void SearchByTitle(string title)
    {
        BookNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Title.Equals(title))
            {
                PrintBook(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("Book not found");
    }

    // Search by Author
    public void SearchByAuthor(string author)
    {
        BookNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Author.Equals(author))
            {
                PrintBook(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("Book not found");
    }

    // Update availability
    public void UpdateAvailability(int id, bool available)
    {
        BookNode temp = head;

        while (temp != null)
        {
            if (temp.BookId == id)
            {
                temp.IsAvailable = available;
                Console.WriteLine("Availability updated");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Book not found");
    }

    // Display forward
    public void DisplayForward()
    {
        if (head == null)
        {
            Console.WriteLine("No books available");
            return;
        }

        BookNode temp = head;
        while (temp != null)
        {
            PrintBook(temp);
            temp = temp.Next;
        }
    }

    // Display reverse
    public void DisplayReverse()
    {
        if (tail == null)
        {
            Console.WriteLine("No books available");
            return;
        }

        BookNode temp = tail;
        while (temp != null)
        {
            PrintBook(temp);
            temp = temp.Prev;
        }
    }

    // Count books
    public void CountBooks()
    {
        int count = 0;
        BookNode temp = head;

        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }

        Console.WriteLine("Total number of books: " + count);
    }

    // Print book
    private void PrintBook(BookNode book)
    {
        Console.WriteLine(
            "ID: " + book.BookId +
            ", Title: " + book.Title +
            ", Author: " + book.Author +
            ", Genre: " + book.Genre +
            ", Available: " + book.IsAvailable
        );
    }
}

// Main class
class Program
{
    static void Main()
    {
        LibraryDoublyLinkedList library = new LibraryDoublyLinkedList();

        library.AddAtEnd(1, "Clean Code", "Robert Martin", "Programming", true);
        library.AddAtBeginning(2, "The Hobbit", "J.R.R. Tolkien", "Fantasy", true);
        library.AddAtPosition(2, 3, "1984", "George Orwell", "Dystopian", false);

        Console.WriteLine("Library Books (Forward):");
        library.DisplayForward();

        Console.WriteLine("\nLibrary Books (Reverse):");
        library.DisplayReverse();

        Console.WriteLine("\nSearch by Author:");
        library.SearchByAuthor("George Orwell");

        Console.WriteLine("\nUpdate Availability:");
        library.UpdateAvailability(3, true);

        Console.WriteLine("\nAfter Update:");
        library.DisplayForward();

        Console.WriteLine("\nRemove Book:");
        library.RemoveByBookId(1);

        Console.WriteLine("\nFinal Library:");
        library.DisplayForward();

        Console.WriteLine("\nBook Count:");
        library.CountBooks();
    }
}
