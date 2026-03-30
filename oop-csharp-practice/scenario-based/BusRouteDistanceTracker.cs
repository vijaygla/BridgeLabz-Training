using System;

class BusRouteDistanceTracker
{
    static void Main(string[] args)
    {
        double totalDistance = 0;

        Console.WriteLine("=== Bus Route Distance Tracker ===");

        while (true)
        {
            // Ask distance between stops
            Console.Write("Enter distance from previous stop (in km): ");
            double distance;

            bool isValid = double.TryParse(Console.ReadLine(), out distance);

            if (!isValid || distance <= 0)
            {
                Console.WriteLine("Invalid distance. Please try again.");
                continue;
            }

            // Add distance to total
            totalDistance = totalDistance + distance;

            Console.WriteLine("Total distance travelled: " + totalDistance + " km");

            // Ask if passenger wants to get off
            Console.Write("Do you want to get off at this stop? (yes/no): ");
            string choice = Console.ReadLine().ToLower();

            if (choice == "yes")
            {
                Console.WriteLine("Passenger exited the bus.");
                Console.WriteLine("Final distance travelled: " + totalDistance + " km");
                break;
            }
        }
    }
}
