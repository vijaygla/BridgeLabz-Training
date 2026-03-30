using System;

// Node class
class TaskNode
{
    public int TaskId;
    public string TaskName;
    public int Priority;
    public string DueDate;

    public TaskNode Next;

    public TaskNode(int taskId, string taskName, int priority, string dueDate)
    {
        TaskId = taskId;
        TaskName = taskName;
        Priority = priority;
        DueDate = dueDate;
        Next = null;
    }
}

// Circular Linked List class
class TaskCircularLinkedList
{
    private TaskNode head;
    private TaskNode current;

    // Add at beginning
    public void AddAtBeginning(int id, string name, int priority, string dueDate)
    {
        TaskNode newNode = new TaskNode(id, name, priority, dueDate);

        if (head == null)
        {
            head = newNode;
            newNode.Next = head;
            current = head;
            return;
        }

        TaskNode temp = head;
        while (temp.Next != head)
        {
            temp = temp.Next;
        }

        newNode.Next = head;
        temp.Next = newNode;
        head = newNode;
    }

    // Add at end
    public void AddAtEnd(int id, string name, int priority, string dueDate)
    {
        TaskNode newNode = new TaskNode(id, name, priority, dueDate);

        if (head == null)
        {
            head = newNode;
            newNode.Next = head;
            current = head;
            return;
        }

        TaskNode temp = head;
        while (temp.Next != head)
        {
            temp = temp.Next;
        }

        temp.Next = newNode;
        newNode.Next = head;
    }

    // Add at specific position (1-based)
    public void AddAtPosition(int position, int id, string name, int priority, string dueDate)
    {
        if (position <= 0)
        {
            Console.WriteLine("Invalid position");
            return;
        }

        if (position == 1)
        {
            AddAtBeginning(id, name, priority, dueDate);
            return;
        }

        TaskNode temp = head;
        for (int i = 1; i < position - 1 && temp.Next != head; i++)
        {
            temp = temp.Next;
        }

        TaskNode newNode = new TaskNode(id, name, priority, dueDate);
        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    // Remove by Task ID
    public void RemoveByTaskId(int id)
    {
        if (head == null)
        {
            Console.WriteLine("Task list is empty");
            return;
        }

        TaskNode temp = head;
        TaskNode prev = null;

        do
        {
            if (temp.TaskId == id)
            {
                if (temp == head)
                {
                    TaskNode last = head;
                    while (last.Next != head)
                    {
                        last = last.Next;
                    }

                    if (head.Next == head)
                    {
                        head = null;
                        current = null;
                        Console.WriteLine("Task removed");
                        return;
                    }

                    last.Next = head.Next;
                    head = head.Next;
                }
                else
                {
                    prev.Next = temp.Next;
                }

                Console.WriteLine("Task removed");
                return;
            }

            prev = temp;
            temp = temp.Next;

        } while (temp != head);

        Console.WriteLine("Task not found");
    }

    // View current task and move to next
    public void ViewCurrentTask()
    {
        if (current == null)
        {
            Console.WriteLine("No tasks available");
            return;
        }

        Console.WriteLine(
            "Task ID: " + current.TaskId +
            ", Name: " + current.TaskName +
            ", Priority: " + current.Priority +
            ", Due Date: " + current.DueDate
        );

        current = current.Next;
    }

    // Display all tasks
    public void DisplayAll()
    {
        if (head == null)
        {
            Console.WriteLine("No tasks available");
            return;
        }

        TaskNode temp = head;
        do
        {
            Console.WriteLine(
                "Task ID: " + temp.TaskId +
                ", Name: " + temp.TaskName +
                ", Priority: " + temp.Priority +
                ", Due Date: " + temp.DueDate
            );
            temp = temp.Next;
        } while (temp != head);
    }

    // Search by Priority
    public void SearchByPriority(int priority)
    {
        if (head == null)
        {
            Console.WriteLine("No tasks available");
            return;
        }

        TaskNode temp = head;
        bool found = false;

        do
        {
            if (temp.Priority == priority)
            {
                Console.WriteLine(
                    "Task ID: " + temp.TaskId +
                    ", Name: " + temp.TaskName +
                    ", Due Date: " + temp.DueDate
                );
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);

        if (!found)
            Console.WriteLine("No task found with this priority");
    }
}

// Main class
class TaskSchedular
{
    static void Main()
    {
        TaskCircularLinkedList scheduler = new TaskCircularLinkedList();

        scheduler.AddAtEnd(1, "Design Module", 1, "10-Jan");
        scheduler.AddAtBeginning(2, "Write Code", 2, "12-Jan");
        scheduler.AddAtPosition(2, 3, "Testing", 1, "15-Jan");

        Console.WriteLine("All Tasks:");
        scheduler.DisplayAll();

        Console.WriteLine("\nView Current Task:");
        scheduler.ViewCurrentTask();

        Console.WriteLine("\nNext Task:");
        scheduler.ViewCurrentTask();

        Console.WriteLine("\nSearch by Priority 1:");
        scheduler.SearchByPriority(1);

        Console.WriteLine("\nRemove Task ID 2:");
        scheduler.RemoveByTaskId(2);

        Console.WriteLine("\nFinal Task List:");
        scheduler.DisplayAll();
    }
}
