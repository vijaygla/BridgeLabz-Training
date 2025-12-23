using System;

class CheckFirstSmallestNumber
{
    static void Main(String[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2= int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        
        if(num1 < num2 && num1 < num3)
        {
            Console.WriteLine("Smallest number : " + num1);
        }
        else if(num2 < num1 && num2 < num3)
        {
            Console.WriteLine("Smallest number : " + num2);
        }
        else
        {
            Console.WriteLine("Smallest number : " + num3);
        }
    }
}
