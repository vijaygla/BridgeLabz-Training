using System;

class TravelInput
{
    static void Main()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter from city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter via city: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter to city: ");
        string toCity = Console.ReadLine();

        Console.Write("Enter distance from-to-via: ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter distance via-to-final: ");
        double viaToFinal = Convert.ToDouble(Console.ReadLine());

        double totalDistance = fromToVia + viaToFinal;

        Console.WriteLine(
            "The results of the trip are: " + name + ", " + totalDistance +
            ", " + fromCity + " to " + toCity + " via " + viaCity
        );

    }
}
