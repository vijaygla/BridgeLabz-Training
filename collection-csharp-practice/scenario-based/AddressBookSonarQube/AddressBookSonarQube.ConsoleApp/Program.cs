using AddressBookSonarQube.Core.Models;
using AddressBookSonarQube.Core.Services;


var service = new AddressBookService();


while (true)
{
    Console.WriteLine("\n1.Create Book 2.Add 3.Edit 4.Delete 5.View 6.Search City 7.Search State\n8.Count City 9.Count State 10.Sort Name 11.Sort City 12.Sort State 13.Exit");
    int choice = int.Parse(Console.ReadLine()!);


    try
    {
        switch (choice)
        {
            case 1:
                Console.Write("Book Name: ");
                service.CreateAddressBook(Console.ReadLine()!);
                break;
            case 2:
                Console.Write("Book: ");
                string book = Console.ReadLine()!;
                var c = new Contact();
                Console.Write("First Name: "); c.FirstName = Console.ReadLine()!;
                Console.Write("City: "); c.City = Console.ReadLine()!;
                Console.Write("State: "); c.State = Console.ReadLine()!;
                service.AddContact(book, c);
                break;
            case 13:
                return;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
