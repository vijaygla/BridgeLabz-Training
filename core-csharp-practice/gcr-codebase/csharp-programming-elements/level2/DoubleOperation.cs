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

        Console.WriteLine(ans1);
        Console.WriteLine(ans2);
        Console.WriteLine(ans3);
        Console.WriteLine(ans4);
    }
}
