using System;

class ArmstrongNumberBetweenRange
{
    static bool IsArmstrong(int num)
    {
        int original = num;
        int sum = 0;
        int digits = num.ToString().Length;

        while (num > 0)
        {
            int rem = num % 10;
            sum += (int)Math.Pow(rem, digits);
            num /= 10;
        }

        return sum == original;
    }

    static void Main()
    {
        Console.Write("Enter start range: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter end range: ");
        int end = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Armstrong numbers are:");
        for (int i = start; i <= end; i++)
        {
            if (IsArmstrong(i))
                Console.WriteLine(i);
        }
    }
}
