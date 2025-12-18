using System;

class KilometerToMiles
{
	static void Main()
	{
		Console.Write("Enter kilometer: ");
		double km = Convert.ToDouble(Console.ReadLine());
		
		double  miles = km * 0.6213721;
		Console.WriteLine("Km to miles: " + miles);
	}
}
