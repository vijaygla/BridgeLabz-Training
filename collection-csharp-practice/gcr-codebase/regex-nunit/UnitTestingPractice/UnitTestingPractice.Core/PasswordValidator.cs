using System.Text.RegularExpressions;

namespace UnitTestingPractice.Core;

public class PasswordValidator
{
    public bool IsValid(string password)
    {
        return password.Length >= 8 &&
               Regex.IsMatch(password, "[A-Z]") &&
               Regex.IsMatch(password, "[0-9]");
    }
}
