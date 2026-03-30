
namespace FactoryRobotHazardAnalyser
{
    public class Utility
    {
        public double CalculateHazardRisk(double armPrecision, double workerDensity, string machinaryState)
        {
            // validate arm precision
            if(armPrecision < 0.0 || armPrecision > 1.0)
            {
                throw new RobotSafetyException("Error: Arm Precision must be 0.0 - 1.0");
            }

            // validate worker density
            if(workerDensity < 1 || workerDensity > 20)
            {
                throw new RobotSafetyException("Error: Worker density must be 1 - 20");
            }

            double machineRiskFactor;
            // validate machinaryState
            switch(machinaryState)
            {
                case "worn":
                    machineRiskFactor = 1.3;
                    break;
                case "faulty":
                    machineRiskFactor = 2.0;
                    break;
                case "critical":
                    machineRiskFactor = 3.0;
                    break;
                
                default: 
                    throw new RobotSafetyException("Error: Unsupported machinary state");
            }

            return ((1.0 - armPrecision) * 15.0) + ((int)workerDensity * machineRiskFactor);
        }
    }
}
