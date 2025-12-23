using System;

class SimpleInterest
{
    static void Main()
    {
        Console.Write("Enter Principal: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time: ");
        double time = Convert.ToDouble(Console.ReadLine());

        double interest = (principal * rate * time) / 100;

        Console.WriteLine(
            "The Simple Interest is " + interest +
            " for Principal " + principal +
            ", Rate of Interest " + rate +
            " and Time " + time
        );

    }
}
