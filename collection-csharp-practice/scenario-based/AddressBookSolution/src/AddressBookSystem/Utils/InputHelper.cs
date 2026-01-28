namespace AddressBookSystem.Utils
{
    public static class InputHelper
    {
        public static string ReadString(string message)
        {
            Console.Write(message);
            return Console.ReadLine() ?? string.Empty;
        }
    }
}
