using AddressBookSonarQube.Core.Exceptions;
using AddressBookSonarQube.Core.Interfaces;
using AddressBookSonarQube.Core.Models;
using System.Collections.Generic;
using System.Linq;


namespace AddressBookSonarQube.Core.Services;


public class AddressBookService : IAddressBookService
{
    private readonly Dictionary<string, AddressBook> _books = new(StringComparer.OrdinalIgnoreCase);

    public void CreateAddressBook(string name)
    {
        if (_books.ContainsKey(name))
            throw new AddressBookException("Address Book already exists");

        _books[name] = new AddressBook(name);
    }

    public void AddContact(string bookName, Contact contact)
    {
        var book = GetBook(bookName);
        if (book.Contacts.Any(c => c.FirstName.Equals(contact.FirstName, StringComparison.OrdinalIgnoreCase)))
            throw new AddressBookException("Duplicate contact");

        book.Contacts.Add(contact);
    }

    public void EditContact(string bookName, string firstName, Contact updated)
    {
        var book = GetBook(bookName);
        var contact = book.Contacts.FirstOrDefault(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
            ?? throw new AddressBookException("Contact not found");

        contact.LastName = updated.LastName;
        contact.Address = updated.Address;
        contact.City = updated.City;
        contact.State = updated.State;
        contact.Zip = updated.Zip;
        contact.PhoneNumber = updated.PhoneNumber;
        contact.Email = updated.Email;
    }

    public void DeleteContact(string bookName, string firstName)
    {
        var book = GetBook(bookName);
        var contact = book.Contacts.FirstOrDefault(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
            ?? throw new AddressBookException("Contact not found");

        book.Contacts.Remove(contact);
    }

    public List<Contact> GetAllContacts(string bookName)
        => GetBook(bookName).Contacts;

    public List<Contact> SearchByCity(string city)
        => _books.Values.SelectMany(b => b.Contacts)
            .Where(c => c.City.Equals(city, StringComparison.OrdinalIgnoreCase)).ToList();

    public List<Contact> SearchByState(string state)
        => _books.Values.SelectMany(b => b.Contacts)
            .Where(c => c.State.Equals(state, StringComparison.OrdinalIgnoreCase)).ToList();

    private AddressBook GetBook(string name) => _books.GetValueOrDefault(name) ?? throw new AddressBookException("Address book not found");

    public Dictionary<string, int> CountByCity() =>
        _books.Values.SelectMany(b => b.Contacts)
            .GroupBy(c => c.City, StringComparer.OrdinalIgnoreCase)
            .ToDictionary(g => g.Key, g => g.Count());

    public Dictionary<string, int> CountByState() =>
        _books.Values.SelectMany(b => b.Contacts)
            .GroupBy(c => c.State, StringComparer.OrdinalIgnoreCase)
            .ToDictionary(g => g.Key, g => g.Count());

    public List<Contact> SortBy(Func<Contact, string> keySelector) =>
        _books.Values.SelectMany(b => b.Contacts)
            .OrderBy(keySelector).ToList();
}
