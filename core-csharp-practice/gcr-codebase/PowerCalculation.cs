using System;

class PowerCalculation 
{
	static void Main()
	{
		Console.Write("Enter base: ");
		int baseNumber = int.Parse(Console.ReadLine());
		Console.Write("Enter power: ");
		int powerNumber = int.Parse(Console.ReadLine());
		int ans = 1;
		
		for(int i=1; i<=powerNumber; i++)
		{
			ans = ans * baseNumber;
		}
		Console.WriteLine("Result: " + ans);
	}
}
