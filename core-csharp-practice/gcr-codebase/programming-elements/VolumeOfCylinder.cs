using System;

class VolumeOfCylinder 
{
	static void Main() 
	{
		Console.Write("Enter radius of cylinder: ");
		double radius = Convert.ToDouble(Console.ReadLine());
		
		double volumeOfCylinder = 3.14 * radius * radius;
		
		Console.WriteLine("Volume of cylineder : " + volumeOfCylinder);
	}
}
