using System;
using OceanFleet.Models;
using OceanFleet.Utils;

namespace OceanFleet
{
    class Program
    {
        static void Main(string[] args)
        {
            VesselUtil vesselUtil = new VesselUtil();

            Console.WriteLine("Enter the number of vessels to be added");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter vessel details");

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                string[] data = input.Split(':');

                Vessel vessel = new Vessel(
                    data[0],
                    data[1],
                    double.Parse(data[2]),
                    data[3]
                );

                vesselUtil.AddVesselPerformance(vessel);
            }

            Console.WriteLine("Enter the Vessel Id to check speed");
            string searchId = Console.ReadLine();

            Vessel foundVessel = vesselUtil.GetVesselById(searchId);

            if (foundVessel != null)
            {
                Console.WriteLine(
                    $"{foundVessel.VesselId} | {foundVessel.VesselName} | " +
                    $"{foundVessel.VesselType} | {foundVessel.AverageSpeed} knots"
                );
            }
            else
            {
                Console.WriteLine($"Vessel Id {searchId} not found");
            }

            Console.WriteLine("High performance vessels are");

            var highPerformanceVessels = vesselUtil.GetHighPerformanceVessels();

            foreach (var vessel in highPerformanceVessels)
            {
                Console.WriteLine(
                    $"{vessel.VesselId} | {vessel.VesselName} | " +
                    $"{vessel.VesselType} | {vessel.AverageSpeed} knots"
                );
            }
        }
    }
}


/*
Sample test case
Enter the number of vessels to be added
3
Enter vessel details
ID : Name
101:Sea King:25.5:Cargo
102:Ocean Star:18.0:Tanker
103:Wave Rider:22.3:Cruise
Enter the Vessel Id to check speed
V001
*/
