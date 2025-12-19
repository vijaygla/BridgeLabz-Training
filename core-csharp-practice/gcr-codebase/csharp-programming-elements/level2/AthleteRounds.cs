using System;

class AthleteRounds
{
    static void Main()
    {
        Console.Write("Enter side1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side3: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        double perimeter = side1 + side2 + side3;
        double rounds = 5000 / perimeter;

        Console.WriteLine(
            $"The total number of rounds the athlete will run is {rounds} to complete 5 km"
        );
    }
}
