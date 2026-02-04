namespace FactoryRobotHazardAnalyser
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter arm precision (0.0 - 1.0) : ");
                double armPrecision = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Worker density (1 - 20) : ");
                double workerDensity = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter machinary state (worn / faulty / critical) : ");
                string? machinaryState = Console.ReadLine();

                if (machinaryState is not null)
                {
                    Utility utility = new Utility();

                    double riskCount = utility.CalculateHazardRisk(armPrecision, workerDensity, machinaryState);

                    Console.WriteLine("Robot Hazard Risk Score : " + riskCount);
                }
            }
            catch (RobotSafetyException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
