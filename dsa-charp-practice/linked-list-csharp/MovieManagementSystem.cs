using System;

// Node class
class MovieNode
{
    public string Title;
    public string Director;
    public int Year;
    public double Rating;

    public MovieNode Prev;
    public MovieNode Next;

    public MovieNode(string title, string director, int year, double rating)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
        Prev = null;
        Next = null;
    }
}

// Doubly Linked List class
class MovieDoublyLinkedList
{
    private MovieNode head;
    private MovieNode tail;

    // Add at beginning
    public void AddAtBeginning(string title, string director, int year, double rating)
    {
        MovieNode newNode = new MovieNode(title, director, year, rating);

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
    public void AddAtEnd(string title, string director, int year, double rating)
    {
        MovieNode newNode = new MovieNode(title, director, year, rating);

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
    public void AddAtPosition(int position, string title, string director, int year, double rating)
    {
        if (position <= 0)
        {
            Console.WriteLine("Invalid position");
            return;
        }

        if (position == 1)
        {
            AddAtBeginning(title, director, year, rating);
            return;
        }

        MovieNode temp = head;
        for (int i = 1; i < position - 1 && temp != null; i++)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Position out of range");
            return;
        }

        MovieNode newNode = new MovieNode(title, director, year, rating);
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

    // Remove by Movie Title
    public void RemoveByTitle(string title)
    {
        MovieNode temp = head;

        while (temp != null)
        {
            if (temp.Title.Equals(title))
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

                Console.WriteLine("Movie removed successfully");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Movie not found");
    }

    // Search by Director
    public void SearchByDirector(string director)
    {
        MovieNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Director.Equals(director))
            {
                PrintMovie(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("No movies found for this director");
    }

    // Search by Rating
    public void SearchByRating(double rating)
    {
        MovieNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Rating == rating)
            {
                PrintMovie(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("No movies found with this rating");
    }

    // Update Rating by Title
    public void UpdateRating(string title, double newRating)
    {
        MovieNode temp = head;

        while (temp != null)
        {
            if (temp.Title.Equals(title))
            {
                temp.Rating = newRating;
                Console.WriteLine("Rating updated successfully");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Movie not found");
    }

    // Display forward
    public void DisplayForward()
    {
        if (head == null)
        {
            Console.WriteLine("No movie records available");
            return;
        }

        MovieNode temp = head;
        while (temp != null)
        {
            PrintMovie(temp);
            temp = temp.Next;
        }
    }

    // Display reverse
    public void DisplayReverse()
    {
        if (tail == null)
        {
            Console.WriteLine("No movie records available");
            return;
        }

        MovieNode temp = tail;
        while (temp != null)
        {
            PrintMovie(temp);
            temp = temp.Prev;
        }
    }

    // Helper method to print movie
    private void PrintMovie(MovieNode movie)
    {
        Console.WriteLine(
            "Title: " + movie.Title +
            ", Director: " + movie.Director +
            ", Year: " + movie.Year +
            ", Rating: " + movie.Rating
        );
    }
}

// Main class
class MovieManagementSystem
{
    static void Main()
    {
        MovieDoublyLinkedList list = new MovieDoublyLinkedList();

        list.AddAtEnd("Inception", "Christopher Nolan", 2010, 9.0);
        list.AddAtBeginning("Interstellar", "Christopher Nolan", 2014, 8.6);
        list.AddAtPosition(2, "Avatar", "James Cameron", 2009, 7.8);

        Console.WriteLine("Movies (Forward):");
        list.DisplayForward();

        Console.WriteLine("\nMovies (Reverse):");
        list.DisplayReverse();

        Console.WriteLine("\nSearch by Director:");
        list.SearchByDirector("Christopher Nolan");

        Console.WriteLine("\nUpdate Rating:");
        list.UpdateRating("Avatar", 8.2);

        Console.WriteLine("\nAfter Update:");
        list.DisplayForward();

        Console.WriteLine("\nRemove Movie:");
        list.RemoveByTitle("Inception");

        Console.WriteLine("\nFinal List:");
        list.DisplayForward();
    }
}
