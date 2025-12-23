using System;

class IntOperation
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int result1 = a + b * c;
        int result2 = a * b + c;
        int result3 = c + a / b;
        int result4 = a % b + c;

        Console.WriteLine(result1);
        Console.WriteLine(result2);
        Console.WriteLine(result3);
        Console.WriteLine(result4);
    }
}
