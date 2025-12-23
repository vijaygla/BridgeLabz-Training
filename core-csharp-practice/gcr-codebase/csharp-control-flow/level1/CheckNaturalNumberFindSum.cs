using System;

class CheckNaturalNumberFindSum
{
    static void Main(String[] args)
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if(num > 0)
        {
            int sum = 0;
            for(int i=1; i<=num; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of natural number: " + sum);
        }
        else {
            Console.WriteLine("Not a natural number");
        }
    }
}
