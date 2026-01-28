using AddressBookSystem.Models;
using AddressBookSystem.Services;
using Xunit;

namespace AddressBookSystem.Tests
{
    public class AddressBookServiceTests
    {
        [Fact]
        public void AddContact_ShouldAddSuccessfully()
        {
            var service = new AddressBookService();
            service.CreateAddressBook("Test");

            var person = new Person
            {
                FirstName = "Amit",
                LastName = "Sharma"
            };

            service.AddContact("Test", person);

            var contacts = service.GetContacts("Test");
            Assert.Single(contacts);
        }

        [Fact]
        public void AddDuplicateContact_ShouldThrowException()
        {
            var service = new AddressBookService();
            service.CreateAddressBook("Test");

            var person = new Person
            {
                FirstName = "Amit",
                LastName = "Sharma"
            };

            service.AddContact("Test", person);

            Assert.Throws<ArgumentException>(() =>
                service.AddContact("Test", person));
        }
    }
}
