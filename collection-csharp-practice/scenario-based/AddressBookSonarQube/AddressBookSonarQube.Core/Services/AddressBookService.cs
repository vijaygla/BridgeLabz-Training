using AddressBookSonarQube.Core.Exceptions;
using AddressBookSonarQube.Core.Interfaces;
using AddressBookSonarQube.Core.Models;
using System.Collections.Generic;
using System.Linq;


namespace AddressBookSonarQube.Core.Services;


public class AddressBookService : IAddressBookService
{
    private readonly Dictionary<string, AddressBook> _books = new();


    public void CreateAddressBook(string name)
    {
        if (_books.ContainsKey(name))
            throw new AddressBookException("Address Book already exists");


        _books[name] = new AddressBook(name);
    }


    public void AddContact(string bookName, Contact contact)
    {
        var book = GetBook(bookName);
        if (book.Contacts.Any(c => c.FirstName == contact.FirstName))
            throw new AddressBookException("Duplicate contact");


        book.Contacts.Add(contact);
    }


    public void EditContact(string bookName, string firstName, Contact updated)
    {
        var book = GetBook(bookName);
        var contact = book.Contacts.FirstOrDefault(c => c.FirstName == firstName)
        ?? throw new AddressBookException("Contact not found");


        book.Contacts.Remove(contact);
        book.Contacts.Add(updated);
    }


    public void DeleteContact(string bookName, string firstName)
    {
        var book = GetBook(bookName);
        var contact = book.Contacts.FirstOrDefault(c => c.FirstName == firstName)
        ?? throw new AddressBookException("Contact not found");


        book.Contacts.Remove(contact);
    }


    public List<Contact> GetAllContacts(string bookName)
    => GetBook(bookName).Contacts;


    public List<Contact> SearchByCity(string city)
    => _books.Values.SelectMany(b => b.Contacts)
    .Where(c => c.City == city).ToList();


    public List<Contact> SearchByState(string state)
    => _books.Values.SelectMany(b => b.Contacts);
}
