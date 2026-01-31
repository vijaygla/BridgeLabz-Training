using System;

namespace FutureLogistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utility utility = new Utility();
            GoodsTransport transport = null;

            while (true)
            {
                Console.WriteLine("\n==== Future Logistics Billing System ====");
                Console.WriteLine("1. Enter Goods Transport Details");
                Console.WriteLine("2. Display Transport Details & Total Charge");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the Goods Transport details:");
                        string input = Console.ReadLine();

                        transport = utility.parseDetails(input);

                        if (!utility.validateTransportId(transport.TransportId))
                        {
                            Console.WriteLine("Please provide a valid record");
                            transport = null;
                        }
                        else
                        {
                            Console.WriteLine("Record stored successfully");
                        }
                        break;

                    case 2:
                        if (transport == null)
                        {
                            Console.WriteLine("No valid record available");
                            break;
                        }

                        Console.WriteLine($"Transporter id : {transport.TransportId}");
                        Console.WriteLine($"Date of transport : {transport.TransportDate}");
                        Console.WriteLine($"Rating of the transport : {transport.TransportRating}");

                        if (transport is BrickTransport bt)
                        {
                            Console.WriteLine($"Quantity of bricks : {bt.BrickQuantity}");
                            Console.WriteLine($"Brick price : {bt.BrickPrice}");
                        }
                        else if (transport is TimberTransport tt)
                        {
                            Console.WriteLine($"Type of the timber : {tt.TimberType}");
                            Console.WriteLine($"Timber price per kilo : {tt.TimberPrice}");
                        }

                        Console.WriteLine($"Vehicle for transport : {transport.vehicleSelection()}");
                        Console.WriteLine($"Total charge : {transport.calculateTotalCharge()}");
                        break;

                    case 3:
                        Console.WriteLine("Thank you for using Future Logistics");
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}



/*
test case
Enter the Goods Transport details
RTS120A:12/8/21:5:BrickTransport:6:800:40

*/
