using System;

class CelsiousToFahrenheit
{
	static void Main()
	{
		Console.Write("Enter temp in celsios: ");
		double celsios = Convert.ToDouble(Console.ReadLine());
		
		double fahrenheit = (celsios * 9 / 5) + 32;
		
		Console.WriteLine("Farenheit temp: " + fahrenheit);
	}
}
