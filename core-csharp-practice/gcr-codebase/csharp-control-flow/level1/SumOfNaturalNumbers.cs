using System;

class SumOfNaturalNumbers
{
    static void Main(String[] args)
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Please enter a natural number.");
            return;
        }

        int sumByFormula = (n * (n + 1)) / 2;
        int sumByLoop = 0;

        for (int i = 1; i <= n; i++)
        {
            sumByLoop += i;
        }

        Console.WriteLine("Sum using formula: " + sumByFormula);
        Console.WriteLine("Sum using for loop: " + sumByLoop);

        if (sumByFormula == sumByLoop)
            Console.WriteLine("Both results are equal");
        else
            Console.WriteLine("Results are not equal");
    }
}
