using System.Text.RegularExpressions;

namespace UserDataJsonApp.Utilities;

public static class InputHelper
{
    public static string ReadString(string message)
    {
        string? input;

        do
        {
            Console.Write(message);
            input = Console.ReadLine();

        } while (string.IsNullOrWhiteSpace(input));

        return input;
    }

    public static int ReadInt(string message)
    {
        int number;

        while (true)
        {
            Console.Write(message);

            if (int.TryParse(Console.ReadLine(), out number))
                return number;

            Console.WriteLine("Invalid number. Try again.");
        }
    }

    public static string ReadEmail(string message)
    {
        string email;
        var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        while (true)
        {
            Console.Write(message);
            email = Console.ReadLine() ?? "";

            if (Regex.IsMatch(email, pattern))
                return email;

            Console.WriteLine("Invalid email format.");
        }
    }
}
