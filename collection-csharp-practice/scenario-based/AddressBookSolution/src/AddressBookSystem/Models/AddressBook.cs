using System.Collections.Generic;

namespace AddressBookSystem.Models
{
    public class AddressBook
    {
        public string Name { get; set; } = string.Empty;

        // Collection usage
        public List<Person> Contacts { get; set; } = new();
    }
}
