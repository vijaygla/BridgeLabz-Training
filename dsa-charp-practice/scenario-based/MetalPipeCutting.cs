using System;
using System.Collections.Generic;

namespace MetalFactoryPipeCutting
{
    // Contract for different rod cutting strategies
    interface ICuttingStrategy
    {
        int CalculateRevenue(int rodLength, Dictionary<int, int> priceChart);
    }

    // Optimized strategy using dynamic programming
    class OptimizedCuttingStrategy : ICuttingStrategy
    {
        public int CalculateRevenue(int rodLength, Dictionary<int, int> priceChart)
        {
            // dp[i] stores max revenue for rod length i
            int[] dp = new int[rodLength + 1];

            for (int i = 1; i <= rodLength; i++)
            {
                int max = 0;

                // Try all possible cuts for current length
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

            return dp[rodLength];
        }
    }

    // Naive strategy without optimization
    class NonOptimizedCuttingStrategy : ICuttingStrategy
    {
        public int CalculateRevenue(int rodLength, Dictionary<int, int> priceChart)
        {
            // Cut rod into two equal parts
            int half = rodLength / 2;

            if (!priceChart.ContainsKey(half))
                return 0;

            return priceChart[half] * 2;
        }
    }

    // Represents a metal rod with its price chart
    class MetalRod
    {
        public int Length { get; private set; }
        private readonly Dictionary<int, int> priceChart;

        public MetalRod(int length)
        {
            Length = length;
            priceChart = new Dictionary<int, int>();
        }

        // Set or update price for a given cut length
        public void SetPrice(int cutLength, int price)
        {
            priceChart[cutLength] = price;
        }

        // Expose price chart for calculation
        public Dictionary<int, int> GetPrices()
        {
            return priceChart;
        }
    }

    // Factory that applies different cutting strategies
    class MetalFactory
    {
        private ICuttingStrategy cuttingStrategy;

        public void SetStrategy(ICuttingStrategy strategy)
        {
            cuttingStrategy = strategy;
        }

        public int CalculateRevenue(MetalRod rod)
        {
            if (cuttingStrategy == null)
                throw new InvalidOperationException("Strategy not set");

            return cuttingStrategy.CalculateRevenue(
                rod.Length,
                rod.GetPrices()
            );
        }
    }

    class MetalPipeCutting
    {
        static void Main()
        {
            // Create rod of length 8
            MetalRod rod = new MetalRod(8);

            // Price chart for different cut lengths
            rod.SetPrice(1, 1);
            rod.SetPrice(2, 5);
            rod.SetPrice(3, 8);
            rod.SetPrice(4, 9);
            rod.SetPrice(5, 10);
            rod.SetPrice(6, 17);
            rod.SetPrice(7, 17);
            rod.SetPrice(8, 20);

            MetalFactory factory = new MetalFactory();

            // Scenario A: Optimized revenue calculation
            factory.SetStrategy(new OptimizedCuttingStrategy());
            Console.WriteLine("Scenario A - Optimized Revenue: " +
                factory.CalculateRevenue(rod));

            // Scenario B: Custom rod length with added pricing
            MetalRod customRod = new MetalRod(9);

            foreach (var price in rod.GetPrices())
                customRod.SetPrice(price.Key, price.Value);

            customRod.SetPrice(9, 24);

            Console.WriteLine("Scenario B - Custom Length Revenue: " +
                factory.CalculateRevenue(customRod));

            // Scenario C: Non-optimized cutting approach
            factory.SetStrategy(new NonOptimizedCuttingStrategy());
            Console.WriteLine("Scenario C - Non Optimized Revenue: " +
                factory.CalculateRevenue(rod));
        }
    }
}
