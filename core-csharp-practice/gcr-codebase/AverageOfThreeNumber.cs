using System;

class AverageOfThreeNumber 
{
	static void Main()
	{
		Console.Write("Enter num1: ");
		double num1 = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter num2: ");
		double num2 = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter num3: ");
		double num3 = Convert.ToDouble(Console.ReadLine());
		
		double average = (num1 + num2 + num3) / 3;
		
		Console.WriteLine("Average of three number: " + average);
	}
}
