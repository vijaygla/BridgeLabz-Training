using System;

class AddTwoNumber
{
	static void Main()
	{
		Console.Write("Enter first number: ");
		int num1 = int.Parse(Console.ReadLine());
		Console.Write("Enter second number: ");
		int num2 = int.Parse(Console.ReadLine());
		
		int sum = num1 + num2;
		Console.WriteLine("Sum of two number: " + sum);
	}
}
