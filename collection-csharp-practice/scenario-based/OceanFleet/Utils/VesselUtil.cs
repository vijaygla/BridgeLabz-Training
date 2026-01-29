using System.Collections.Generic;
using System.Linq;
using OceanFleet.Models;

namespace OceanFleet.Utils
{
    public class VesselUtil
    {
        private List<Vessel> vesselList = new List<Vessel>();

        public List<Vessel> VesselList
        {
            get { return vesselList; }
            set { vesselList = value; }
        }

        // Requirement 1: Add vessel
        public void AddVesselPerformance(Vessel vessel)
        {
            vesselList.Add(vessel);
        }

        // Requirement 2: Get vessel by Id (case-sensitive)
        public Vessel GetVesselById(string vesselId)
        {
            return vesselList.FirstOrDefault(v => v.VesselId == vesselId);
        }

        // Requirement 3: Get high performance vessels
        public List<Vessel> GetHighPerformanceVessels()
        {
            if (vesselList.Count == 0)
                return new List<Vessel>();

            double maxSpeed = vesselList.Max(v => v.AverageSpeed);
            return vesselList.Where(v => v.AverageSpeed == maxSpeed).ToList();
        }
    }
}
