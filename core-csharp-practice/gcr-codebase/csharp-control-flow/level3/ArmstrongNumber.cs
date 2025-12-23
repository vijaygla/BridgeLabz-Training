using System;

class ArmstrongNumber
{
    static void Main(String[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int originalNumber = number;
        int sum = 0;

        while (number != 0)
        {
            int remainder = number % 10;      
            sum = sum + (remainder * remainder * remainder); 
            number = number / 10;             
        }

        if (sum == originalNumber)
            Console.WriteLine("Armstrong Number");
        else
            Console.WriteLine("Not an Armstrong Number");
    }
}
33