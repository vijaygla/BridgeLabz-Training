using System;

class CalculateSimpleInterest
{
	static void Main()
	{
		Console.Write("Enter principle: ");
		double p = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter rate: ");
		double r = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter time: ");
		double t = Convert.ToDouble(Console.ReadLine());
		
		double si = (p * r * t) / 100;
		
		Console.WriteLine("Simple Intrest: " + si);
	}
}

