using System;
using System.IO;

class UserInputToFile
{
    static void Main()
    {
        try
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            string age = Console.ReadLine();

            Console.Write("Favorite Language: ");
            string lang = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter("user.txt"))
            {
                // Writing user data to file
                writer.WriteLine($"Name: {name}");
                writer.WriteLine($"Age: {age}");
                writer.WriteLine($"Language: {lang}");
            }

            Console.WriteLine("Data saved successfully");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
