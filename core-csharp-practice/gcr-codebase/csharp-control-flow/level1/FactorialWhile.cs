using System;

class FactorialWhile
{
    static void Main(String[] args)
    {
        Console.Write("Enter an integer: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        int fact = 1;
        int i = 1;

        while (i <= n)
        {
            fact *= i;
            i++;
        }

        Console.WriteLine("Factorial is: " + fact);
    }
}
