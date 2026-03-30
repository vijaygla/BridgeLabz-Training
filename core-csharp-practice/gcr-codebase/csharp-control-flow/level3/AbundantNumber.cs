using System;

class AbundantNumber
{
    static void Main(String[] args)
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int sum = 0;

        // this loop can be run up to the num given by the user
        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
                sum = sum + i;
        }

        if (sum > num)
            Console.WriteLine("Abundant Number");
        else
            Console.WriteLine("Not an Abundant Number");
    }
}
