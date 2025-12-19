using System;

class DoubleOperation
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double ans1 = a + b * c;
        double ans2 = a * b + c;
        double ans3 = c + a / b;
        double ans4 = a % b + c;

        Console.WriteLine(
            $"The results of Double Operations are {ans1}, {ans2}, {ans3}, and {ans4}"
        );
    }
}
