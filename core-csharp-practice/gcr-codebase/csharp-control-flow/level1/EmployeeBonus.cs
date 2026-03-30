using System;

class EmployeeBonus
{
    static void Main(String[] args)
    {
        Console.Write("Enter salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter years of service: ");
        int years = Convert.ToInt32(Console.ReadLine());

        if (years > 5)
        {
            double bonus = salary * 0.05;
            Console.WriteLine("Bonus Amount: " + bonus);
        }
        else
        {
            Console.WriteLine("No bonus applicable.");
        }
    }
}
