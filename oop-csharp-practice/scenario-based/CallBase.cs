using System;

class CallLog
{
    private string phoneNumber;
    private string message;
    private DateTime timeStamp;

    // Read-only properties (Encapsulation)
    public string PhoneNumber { get { return phoneNumber; } }
    public string Message { get { return message; } }
    public DateTime TimeStamp { get { return timeStamp; } }

    public CallLog(string phoneNumber, string message, DateTime timeStamp)
    {
        this.phoneNumber = phoneNumber;
        this.message = message;
        this.timeStamp = timeStamp;
    }

    // Object prints its own data
    public void Display()
    {
        Console.WriteLine("Phone Number : " + phoneNumber);
        Console.WriteLine("Message      : " + message);
        Console.WriteLine("Time Stamp   : " + timeStamp);
        Console.WriteLine("-----------------------------");
    }
}

class CallLogManager
{
    private CallLog[] logs;
    private int index;

    public CallLogManager(int size)
    {
        logs = new CallLog[size];
        index = 0;
    }

    // Add a call log
    public void AddCallLog(CallLog log)
    {
        if (index < logs.Length)
        {
            logs[index] = log;
            index++;
            Console.WriteLine("Call log added successfully.\n");
        }
        else
        {
            Console.WriteLine("Call log storage is full.\n");
        }
    }

    // Search by keyword in message
    public void SearchByKeyword(string keyword)
    {
        bool found = false;

        for (int i = 0; i < index; i++)
        {
            if (logs[i].Message.Contains(keyword))
            {
                logs[i].Display();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No call logs found with keyword: " + keyword + "\n");
        }
    }
}

class CallBase
{
    static void Main(string[] args)
    {
        Console.Write("Enter size of call log array: ");
        int size = int.Parse(Console.ReadLine());

        CallLogManager manager = new CallLogManager(size);

        while (true)
        {
            Console.WriteLine("\n--- Call Log Manager ---");
            Console.WriteLine("1. Add Call Log");
            Console.WriteLine("2. Search by Keyword");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Phone Number: ");
                    string phone = Console.ReadLine();

                    Console.Write("Enter Message: ");
                    string message = Console.ReadLine();

                    Console.Write("Enter TimeStamp (yyyy-MM-dd HH:mm): ");
                    DateTime time = DateTime.Parse(Console.ReadLine());

                    CallLog log = new CallLog(phone, message, time);
                    manager.AddCallLog(log);
                    break;

                case 2:
                    Console.Write("Enter keyword to search: ");
                    string keyword = Console.ReadLine();
                    manager.SearchByKeyword(keyword);
                    break;

                case 3:
                    Console.WriteLine("Exiting application...");
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}

