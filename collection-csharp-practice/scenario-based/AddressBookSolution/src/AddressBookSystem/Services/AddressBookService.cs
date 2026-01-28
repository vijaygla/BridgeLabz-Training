using AddressBookSystem.Models;

namespace AddressBookSystem.Services
{
    public class AddressBookService
    {
        // Dictionary + Generics
        private readonly Dictionary<string, AddressBook> _addressBooks = new();

        public void CreateAddressBook(string name)
        {
            if (_addressBooks.ContainsKey(name))
                throw new InvalidOperationException("Address Book already exists");

            _addressBooks[name] = new AddressBook { Name = name };
        }

        public void AddContact(string bookName, Person person)
        {
            if (!_addressBooks.ContainsKey(bookName))
                throw new KeyNotFoundException("Address Book not found");

            var book = _addressBooks[bookName];

            if (book.Contacts.Contains(person))
                throw new ArgumentException("Duplicate contact");

            book.Contacts.Add(person);
        }

        public List<Person> GetContacts(string bookName)
        {
            if (!_addressBooks.ContainsKey(bookName))
                throw new KeyNotFoundException("Address Book not found");

            return _addressBooks[bookName].Contacts;
        }
    }
}
