using System;
using EventTracker.Core.Actions;
using EventTracker.Core.Services;

namespace EventTracker.App
{
    // Menu driven UI
    public class Menu
    {
        public static void Start()
        {
            UserActions actions = new();

            while (true)
            {
                Console.WriteLine("\n--- Event Tracker Menu ---");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Upload File");
                Console.WriteLine("3. Delete File");
                Console.WriteLine("4. Exit");
                Console.Write("Choose option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AuditScanner.Execute(actions, "Login");
                        break;
                    case "2":
                        AuditScanner.Execute(actions, "UploadFile");
                        break;
                    case "3":
                        AuditScanner.Execute(actions, "DeleteFile");
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}
