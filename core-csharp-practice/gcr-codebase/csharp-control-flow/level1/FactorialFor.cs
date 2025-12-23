using System;

class FactorialFor
{
    static void Main(String[] args)
    {
        Console.Write("Enter an integer: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Please enter a natural number.");
            return;
        }

        int fact = 1;

        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }

        Console.WriteLine("Factorial is: " + fact);
    }
}
