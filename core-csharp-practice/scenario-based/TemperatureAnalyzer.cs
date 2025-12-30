using System;

class TemperatureAnalyzer
{
    // Method to analyze weekly temperature data
    static float[] AnalyzeTemperature(float[,] temp)
    {
        float[] dailyAverage = new float[7];

        int hottestDay = 0;
        int coldestDay = 0;

        // Calculate average temperature for each day
        for (int day = 0; day < 7; day++)
        {
            float sum = 0;

            for (int hour = 0; hour < 24; hour++)
            {
                sum += temp[day, hour];
            }

            dailyAverage[day] = sum / 24;
        }

        float hottestAvg = dailyAverage[0];
        float coldestAvg = dailyAverage[0];

        // Find hottest and coldest day
        for (int day = 1; day < 7; day++)
        {
            if (dailyAverage[day] > hottestAvg)
            {
                hottestAvg = dailyAverage[day];
                hottestDay = day;
            }

            if (dailyAverage[day] < coldestAvg)
            {
                coldestAvg = dailyAverage[day];
                coldestDay = day;
            }
        }

        // Display results
        Console.WriteLine("\nAverage Temperature Per Day:");
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("Day " + (i + 1) + ": " + dailyAverage[i]);
        }

        Console.WriteLine("\nHottest Day : Day " + (hottestDay + 1));
        Console.WriteLine("Coldest Day : Day " + (coldestDay + 1));

        return dailyAverage;
    }

    static void Main()
    {
        float[,] temperatures = new float[7, 24];

        // Input temperature values
        for (int day = 0; day < 7; day++)
        {
            Console.WriteLine("\nEnter temperatures for Day " + (day + 1));

            for (int hour = 0; hour < 24; hour++)
            {
                Console.Write("Hour " + (hour + 1) + ": ");

                if (!float.TryParse(Console.ReadLine(), out temperatures[day, hour]))
                {
                    Console.WriteLine("Invalid input! Enter a valid number.");
                    hour--; // retry same hour
                }
            }
        }

        AnalyzeTemperature(temperatures);
    }
}


/*
sample test case
Enter temperatures for Day 1
25
26
27
28
29
30
31
30
29
28
27
26
25
24
23
22
21
22
23
24
25
26
27
28

Enter temperatures for Day 2
24
25
26
27
28
29
30
31
32
31
30
29
28
27
26
25
24
23
22
23
24
25
26
27

Enter temperatures for Day 3
20
21
22
23
24
25
26
27
28
29
30
29
28
27
26
25
24
23
22
21
20
21
22
23

Enter temperatures for Day 4
30
31
32
33
34
35
36
35
34
33
32
31
30
29
28
27
26
25
24
23
22
23
24
25

Enter temperatures for Day 5
22
23
24
25
26
27
28
29
30
29
28
27
26
25
24
23
22
21
20
21
22
23
24
25

Enter temperatures for Day 6
18
19
20
21
22
23
24
25
26
27
28
27
26
25
24
23
22
21
20
19
18
19
20
21

Enter temperatures for Day 7
26
27
28
29
30
31
32
33
34
33
32
31
30
29
28
27
26
25
24
23
22
23
24
25
*/