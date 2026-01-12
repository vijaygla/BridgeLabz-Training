using System;
using System.Collections.Generic;

namespace CustomFurnitureManufacturing
{
    // Strategy contract for different cutting logics
    interface ICutStrategy
    {
        int CalculateEarnings(int rodLength, Dictionary<int, int> priceChart, int allowedWaste);
    }

    // Maximizes revenue for the usable length (rodLength - allowedWaste)
    class MaxRevenueStrategy : ICutStrategy
    {
        public int CalculateEarnings(int rodLength, Dictionary<int, int> priceChart, int allowedWaste)
        {
            int usableLength = rodLength - allowedWaste;
            int[] dp = new int[usableLength + 1];

            // Dynamic programming to compute max revenue
            for (int i = 1; i <= usableLength; i++)
            {
                int max = 0;

                for (int cut = 1; cut <= i; cut++)
                {
                    if (priceChart.ContainsKey(cut))
                    {
                        int value = priceChart[cut] + dp[i - cut];
                        if (value > max)
                            max = value;
                    }
                }

                dp[i] = max;
            }

            return dp[usableLength];
        }
    }

    // Tries different waste values to balance revenue and minimal waste
    class BalancedRevenueWasteStrategy : ICutStrategy
    {
        public int CalculateEarnings(int rodLength, Dictionary<int, int> priceChart, int allowedWaste)
        {
            int bestRevenue = 0;

            // Try all waste limits up to allowedWaste
            for (int waste = 0; waste <= allowedWaste; waste++)
            {
                int usableLength = rodLength - waste;
                int[] dp = new int[usableLength + 1];

                for (int i = 1; i <= usableLength; i++)
                {
                    int max = 0;

                    for (int cut = 1; cut <= i; cut++)
                    {
                        if (priceChart.ContainsKey(cut))
                        {
                            int value = priceChart[cut] + dp[i - cut];
                            if (value > max)
                                max = value;
                        }
                    }

                    dp[i] = max;
                }

                if (dp[usableLength] > bestRevenue)
                    bestRevenue = dp[usableLength];
            }

            return bestRevenue;
        }
    }

    // Represents the wooden rod with pricing details
    class WoodenRod
    {
        public int Length { get; private set; }
        private readonly Dictionary<int, int> priceChart;

        public WoodenRod(int length)
        {
            Length = length;
            priceChart = new Dictionary<int, int>();
        }

        public void SetPrice(int size, int price)
        {
            priceChart[size] = price;
        }

        public Dictionary<int, int> GetPrices()
        {
            return priceChart;
        }
    }

    // Workshop that uses different cutting strategies
    class CarpenterWorkshop
    {
        private ICutStrategy cutStrategy;

        public void SetStrategy(ICutStrategy strategy)
        {
            cutStrategy = strategy;
        }

        public int CalculateEarnings(WoodenRod rod, int allowedWaste)
        {
            if (cutStrategy == null)
                throw new InvalidOperationException("Cut strategy not set");

            return cutStrategy.CalculateEarnings(
                rod.Length,
                rod.GetPrices(),
                allowedWaste
            );
        }
    }

    class Program
    {
        static void Main()
        {
            // Create a 12ft wooden rod
            WoodenRod rod = new WoodenRod(12);

            // Price chart based on cut size
            rod.SetPrice(1, 2);
            rod.SetPrice(2, 5);
            rod.SetPrice(3, 7);
            rod.SetPrice(4, 9);
            rod.SetPrice(5, 10);
            rod.SetPrice(6, 14);
            rod.SetPrice(7, 16);
            rod.SetPrice(8, 17);
            rod.SetPrice(9, 20);
            rod.SetPrice(10, 24);
            rod.SetPrice(11, 25);
            rod.SetPrice(12, 30);

            CarpenterWorkshop workshop = new CarpenterWorkshop();

            // Scenario A: Maximize revenue with no waste
            workshop.SetStrategy(new MaxRevenueStrategy());
            Console.WriteLine("Scenario A - Max Revenue: " +
                workshop.CalculateEarnings(rod, 0));

            // Scenario B: Fixed waste constraint
            Console.WriteLine("Scenario B - Revenue With Waste Constraint: " +
                workshop.CalculateEarnings(rod, 2));

            // Scenario C: Balance revenue and minimal waste
            workshop.SetStrategy(new BalancedRevenueWasteStrategy());
            Console.WriteLine("Scenario C - Revenue With Minimal Waste Preference: " +
                workshop.CalculateEarnings(rod, 3));
        }
    }
}
