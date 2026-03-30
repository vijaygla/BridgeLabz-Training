using UserDataJsonApp.Models;
using UserDataJsonApp.Services;
using UserDataJsonApp.Utilities;

class Program
{
    static JsonStorageService storage = new JsonStorageService();

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== USER JSON STORAGE APP =====");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. View Users");
            Console.WriteLine("3. Exit");

            int choice = InputHelper.ReadInt("Enter choice: ");

            switch (choice)
            {
                case 1:
                    AddUser();
                    break;

                case 2:
                    ViewUsers();
                    break;

                case 3:
                    return;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    static void AddUser()
    {
        Console.WriteLine("\n--- Add User ---");

        string name = InputHelper.ReadString("Name: ");
        int age = InputHelper.ReadInt("Age: ");
        string email = InputHelper.ReadEmail("Email: ");

        var users = storage.LoadUsers();

        int id = users.Count + 1;

        var user = new User
        {
            Id = id,
            Name = name,
            Age = age,
            Email = email
        };

        storage.AddUser(user);

        Console.WriteLine("User saved successfully!");
    }

    static void ViewUsers()
    {
        Console.WriteLine("\n--- Users List ---");

        var users = storage.LoadUsers();

        if (users.Count == 0)
        {
            Console.WriteLine("No users found.");
            return;
        }

        foreach (var u in users)
        {
            Console.WriteLine($"{u.Id} | {u.Name} | {u.Age} | {u.Email}");
        }
    }
}
