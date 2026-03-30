using System;

class AreaOfCircle
{
	static void Main()
	{
		Console.Write("Enter radius of circle: ");
		double radius = Convert.ToDouble(Console.ReadLine());
		double area = 3.14 * radius * radius;
		
		Console.WriteLine("Area of circle: " + area);
	}
}

