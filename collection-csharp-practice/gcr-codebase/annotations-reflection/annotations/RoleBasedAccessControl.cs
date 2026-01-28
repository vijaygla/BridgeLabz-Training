using System;

[AttributeUsage(AttributeTargets.Method)]
class RoleAllowedAttribute : Attribute
{
    public string Role { get; }

    public RoleAllowedAttribute(string role)
    {
        Role = role;
    }
}

class AdminService
{
    [RoleAllowed("ADMIN")]
    public void DeleteUser()
    {
        Console.WriteLine("User deleted");
    }
}

class Program
{
    static void Main()
    {
        string currentRole = "USER";
        var method = typeof(AdminService).GetMethod("DeleteUser");
        var attr = (RoleAllowedAttribute)Attribute.GetCustomAttribute(method, typeof(RoleAllowedAttribute));

        if (attr.Role == currentRole)
            method.Invoke(new AdminService(), null);
        else
            Console.WriteLine("Access Denied!");
    }
}
