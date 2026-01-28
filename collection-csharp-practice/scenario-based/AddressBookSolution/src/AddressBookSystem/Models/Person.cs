namespace AddressBookSystem.Models
{
    public class Person
    {
        // Basic contact details
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        // Prevent duplicate contacts
        public override bool Equals(object? obj)
        {
            if (obj is not Person other)
                return false;

            return FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase)
                   && LastName.Equals(other.LastName, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName);
        }
    }
}
