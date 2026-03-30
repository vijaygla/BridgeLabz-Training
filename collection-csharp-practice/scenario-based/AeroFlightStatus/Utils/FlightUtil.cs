using System.Text.RegularExpressions;
using AeroFlightStatus.Exceptions;

namespace AeroFlightStatus.Utils
{
    public class FlightUtil
    {
        // Validate flight number format: FL-XXXX (1000–9999)
        public bool validateFlightNumber(string flightNumber)
        {
            string pattern = @"^FL-[1-9][0-9]{3}$";

            if (!Regex.IsMatch(flightNumber, pattern))
            {
                throw new InvalidFlightException(
                    $"The flight number {flightNumber} is invalid"
                );
            }
            return true;
        }

        // Validate flight name (case-sensitive)
        public bool validateFlightName(string flightName)
        {
            if (flightName != "SpiceJet" &&
                flightName != "Vistara" &&
                flightName != "IndiGo" &&
                flightName != "Air Arabia")
            {
                throw new InvalidFlightException(
                    $"The flight name {flightName} is invalid"
                );
            }
            return true;
        }

        // Validate passenger count
        public bool validatePassengerCount(int passengerCount, string flightName)
        {
            int maxCapacity = flightName switch
            {
                "SpiceJet" => 396,
                "Vistara" => 615,
                "IndiGo" => 230,
                "Air Arabia" => 130,
                _ => throw new InvalidFlightException($"The flight name {flightName} is invalid")
            };

            if (passengerCount <= 0 || passengerCount > maxCapacity)
            {
                throw new InvalidFlightException(
                    $"The passenger count {passengerCount} is invalid for {flightName}"
                );
            }
            return true;
        }

        // Calculate fuel required
        public double calculateFuelToFillTank(string flightName, double currentFuelLevel)
        {
            double maxFuelCapacity = flightName switch
            {
                "SpiceJet" => 200000,
                "Vistara" => 300000,
                "IndiGo" => 250000,
                "Air Arabia" => 150000,
                _ => throw new InvalidFlightException($"Invalid fuel level for {flightName}")
            };

            if (currentFuelLevel < 0 || currentFuelLevel > maxFuelCapacity)
            {
                throw new InvalidFlightException(
                    $"Invalid fuel level for {flightName}"
                );
            }

            return maxFuelCapacity - currentFuelLevel;
        }
    }
}
