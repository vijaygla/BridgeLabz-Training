using System.Text.Json;
using UserDataJsonApp.Models;

namespace UserDataJsonApp.Services;

public class JsonStorageService
{
    private readonly string _filePath = "Data/users.json";

    public JsonStorageService()
    {
        if (!File.Exists(_filePath))
        {
            Directory.CreateDirectory("Data");
            File.WriteAllText(_filePath, "[]");
        }
    }

    public List<User> LoadUsers()
    {
        var json = File.ReadAllText(_filePath);

        return JsonSerializer.Deserialize<List<User>>(json)
               ?? new List<User>();
    }

    public void SaveUsers(List<User> users)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        var json = JsonSerializer.Serialize(users, options);

        File.WriteAllText(_filePath, json);
    }

    public void AddUser(User user)
    {
        var users = LoadUsers();

        users.Add(user);

        SaveUsers(users);
    }
}
