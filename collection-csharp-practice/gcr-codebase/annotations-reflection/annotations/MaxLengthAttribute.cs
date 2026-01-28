using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
class MaxLengthAttribute : Attribute
{
    public int Value { get; }

    public MaxLengthAttribute(int value)
    {
        Value = value;
    }
}

class User
{
    [MaxLength(5)] //  Annotation applied
    public string Username;

    public User(string username)
    {
        FieldInfo? field = typeof(User).GetField("Username");

        MaxLengthAttribute? attr =
            field?.GetCustomAttribute<MaxLengthAttribute>();

        if (attr != null && username.Length > attr.Value)
        {
            throw new ArgumentException("Username too long");
        }

        Username = username;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            User user1 = new User("Admin");   //  OK
            Console.WriteLine(user1.Username);

            User user2 = new User("Administrator"); //  Exception
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
