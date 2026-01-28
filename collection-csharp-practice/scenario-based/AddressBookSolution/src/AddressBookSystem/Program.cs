using AddressBookSystem.Models;
using AddressBookSystem.Services;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main()
        {
            var service = new AddressBookService();

            try
            {
                service.CreateAddressBook("Office");

                service.AddContact("Office", new Person
                {
                    FirstName = "John",
                    LastName = "Doe",
                    City = "Pune",
                    State = "MH",
                    Email = "john@company.com"
                });

                Console.WriteLine("Contact added successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
