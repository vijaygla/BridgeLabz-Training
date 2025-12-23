using System;

class CelsiusToFahrenheit
{
    static void Main(String[] args)
    {
        Console.Write("Enter Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("Feranhit: " + fahrenheit);
    }
}
