using System;

class CircularTour
{
    static void Main(string[] args)
    {
        int[] petrol = { 6, 3, 7 };
        int[] distance = { 4, 6, 3 };

        int start = 0;
        int surplus = 0;
        int deficit = 0;

        for (int i = 0; i < petrol.Length; i++)
        {
            surplus += petrol[i] - distance[i];

            if (surplus < 0)
            {
                deficit += surplus;
                start = i + 1;
                surplus = 0;
            }
        }

        if (surplus + deficit >= 0)
        {
            Console.WriteLine("Start index: " + start);
        }
        else
        {
            Console.WriteLine("No possible tour");
        }

        Console.ReadLine();
    }
}
