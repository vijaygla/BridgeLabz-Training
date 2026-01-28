using System;
using System.Reflection;
using System.Text;

[AttributeUsage(AttributeTargets.Field)]
class JsonFieldAttribute : Attribute
{
    public string Name { get; set; }
}

class User
{
    [JsonField(Name = "user_name")]
    public string Name = "vijay";
}

class Program
{
    static void Main()
    {
        User user = new User();
        StringBuilder json = new StringBuilder("{");

        foreach (var field in typeof(User).GetFields())
        {
            var attr = field.GetCustomAttribute<JsonFieldAttribute>();
            if (attr != null)
                json.Append($"\"{attr.Name}\":\"{field.GetValue(user)}\"");
        }

        json.Append("}");
        Console.WriteLine(json);
    }
}
