using NUnit.Framework;
using AddressBookSonarQube.Core.Services;
using AddressBookSonarQube.Core.Models;


[TestFixture]
public class AddressBookServiceTests
{
    private AddressBookService _service;


    [SetUp]
    public void Setup()
    {
        _service = new AddressBookService();
        _service.CreateAddressBook("Test");
    }


    [Test]
    public void AddContact_ShouldIncreaseCount()
    {
        _service.AddContact("Test", new Contact { FirstName = "A", City = "Pune" });
        Assert.AreEqual(1, _service.GetAllContacts("Test").Count);
    }
}
