using System;

// Node class
class StudentNode
{
    public int RollNo;
    public string Name;
    public int Age;
    public string Grade;
    public StudentNode Next;

    public StudentNode(int rollNo, string name, int age, string grade)
    {
        RollNo = rollNo;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}

// Singly Linked List class
class StudentLinkedList
{
    private StudentNode head;

    // Add at beginning
    public void AddAtBeginning(int rollNo, string name, int age, string grade)
    {
        StudentNode newNode = new StudentNode(rollNo, name, age, grade);
        newNode.Next = head;
        head = newNode;
    }

    // Add at end
    public void AddAtEnd(int rollNo, string name, int age, string grade)
    {
        StudentNode newNode = new StudentNode(rollNo, name, age, grade);

        if (head == null)
        {
            head = newNode;
            return;
        }

        StudentNode temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newNode;
    }

    // Add at specific position (1-based)
    public void AddAtPosition(int position, int rollNo, string name, int age, string grade)
    {
        if (position <= 0)
        {
            Console.WriteLine("Invalid position");
            return;
        }

        if (position == 1)
        {
            AddAtBeginning(rollNo, name, age, grade);
            return;
        }

        StudentNode temp = head;
        for (int i = 1; i < position - 1 && temp != null; i++)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Position out of range");
            return;
        }

        StudentNode newNode = new StudentNode(rollNo, name, age, grade);
        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    // Delete by Roll Number
    public void DeleteByRollNo(int rollNo)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        if (head.RollNo == rollNo)
        {
            head = head.Next;
            Console.WriteLine("Student record deleted");
            return;
        }

        StudentNode temp = head;
        while (temp.Next != null && temp.Next.RollNo != rollNo)
        {
            temp = temp.Next;
        }

        if (temp.Next == null)
        {
            Console.WriteLine("Student not found");
        }
        else
        {
            temp.Next = temp.Next.Next;
            Console.WriteLine("Student record deleted");
        }
    }

    // Search by Roll Number
    public void SearchByRollNo(int rollNo)
    {
        StudentNode temp = head;
        while (temp != null)
        {
            if (temp.RollNo == rollNo)
            {
                Console.WriteLine(
                    "Found: RollNo = " + temp.RollNo +
                    ", Name = " + temp.Name +
                    ", Age = " + temp.Age +
                    ", Grade = " + temp.Grade
                );
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found");
    }

    // Update Grade
    public void UpdateGrade(int rollNo, string newGrade)
    {
        StudentNode temp = head;
        while (temp != null)
        {
            if (temp.RollNo == rollNo)
            {
                temp.Grade = newGrade;
                Console.WriteLine("Grade updated successfully");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found");
    }

    // Display all students
    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("No student records available");
            return;
        }

        StudentNode temp = head;
        while (temp != null)
        {
            Console.WriteLine(
                "RollNo: " + temp.RollNo +
                ", Name: " + temp.Name +
                ", Age: " + temp.Age +
                ", Grade: " + temp.Grade
            );
            temp = temp.Next;
        }
    }
}

// Main class
class StudentRecordManagementSystem
{
    static void Main()
    {
        StudentLinkedList list = new StudentLinkedList();

        list.AddAtEnd(1, "vijay", 20, "A");
        list.AddAtBeginning(2, "kumar", 21, "B");
        list.AddAtPosition(2, 3, "gupta", 22, "A");

        Console.WriteLine("Student Records:");
        list.Display();

        Console.WriteLine("\nSearching Roll No 3:");
        list.SearchByRollNo(3);

        Console.WriteLine("\nUpdating Grade for Roll No 2:");
        list.UpdateGrade(2, "A+");

        Console.WriteLine("\nAfter Update:");
        list.Display();

        Console.WriteLine("\nDeleting Roll No 1:");
        list.DeleteByRollNo(1);

        Console.WriteLine("\nFinal Records:");
        list.Display();
    }
}
