using System;

class Circle
{
    // Private field
    private double radius;

    // Constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Method to calculate area
    public double CalculateArea()
    {
        return 3.14 * radius * radius;
    }

    // Method to calculate circumference
    public double CalculateCircumference()
    {
        return 2 * 3.14 * radius;
    }

    // Method to display results
    public void DisplayDetails()
    {
        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Area: " + CalculateArea());
        Console.WriteLine("Circumference: " + CalculateCircumference());
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle(7);
        circle.DisplayDetails();
    }
}
