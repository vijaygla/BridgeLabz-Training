using System;
using AeroFlightStatus.Exceptions;
using AeroFlightStatus.Utils;

namespace AeroFlightStatus.UI
{
    public class UserInterface
    {
        public void Start()
        {
            FlightUtil flightUtil = new FlightUtil();
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\n===== AeroFlightStatus System =====");
                Console.WriteLine("1. Validate Flight & Calculate Fuel");
                Console.WriteLine("2. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        HandleFlightProcess(flightUtil);
                        break;

                    case "2":
                        Console.WriteLine("Thank you for using AeroFlightStatus!");
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void HandleFlightProcess(FlightUtil flightUtil)
        {
            try
            {
                Console.WriteLine("\nSelect Flight:");
                Console.WriteLine("1. SpiceJet");
                Console.WriteLine("2. Vistara");
                Console.WriteLine("3. IndiGo");
                Console.WriteLine("4. Air Arabia");
                Console.Write("Enter option: ");

                int option = int.Parse(Console.ReadLine() ?? "0");

                string flightName = option switch
                {
                    1 => "SpiceJet",
                    2 => "Vistara",
                    3 => "IndiGo",
                    4 => "Air Arabia",
                    _ => throw new InvalidFlightException("The flight name is invalid")
                };

                Console.Write("Enter Flight Number (FL-XXXX): ");
                string flightNumber = Console.ReadLine();

                Console.Write("Enter Passenger Count: ");
                int passengerCount = int.Parse(Console.ReadLine() ?? "0");

                Console.Write("Enter Current Fuel Level: ");
                double currentFuel = double.Parse(Console.ReadLine() ?? "0");

                flightUtil.validateFlightNumber(flightNumber);
                flightUtil.validateFlightName(flightName);
                flightUtil.validatePassengerCount(passengerCount, flightName);

                double fuelRequired =
                    flightUtil.calculateFuelToFillTank(flightName, currentFuel);

                Console.WriteLine(
                    $"Fuel required to fill the tank: {fuelRequired} liters");
            }
            catch (InvalidFlightException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format.");
            }
        }
    }
}


// FL-1234:SpiceJet:250:50000
