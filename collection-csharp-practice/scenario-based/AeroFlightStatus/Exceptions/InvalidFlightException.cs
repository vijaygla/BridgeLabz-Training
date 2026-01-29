using System;

namespace AeroFlightStatus.Exceptions
{
    // Custom exception for invalid flight details
    public class InvalidFlightException : Exception
    {
        public InvalidFlightException(string message) : base(message)
        {
        }
    }
}
