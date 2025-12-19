using System;

// Base class
class Calculator
{
    // public modifieer
    public int Sum(int a, int b)
    {
        return a + b;
    }

    // private →  only inside this class
    private int Difference(int a, int b)
    {
        return a - b;
    }

    // protected → accessible in this class and derived class
    protected int Product(int a, int b)
    {
        return a * b;
    }

    // internal → accessible within same assembly/project
    internal int Divide(int a, int b)
    {
        return a / b;
    }

    // protected internal → same assembly OR derived class
    protected internal int Modulus(int a, int b)
    {
        return a % b;
    }

    // private protected → same class AND derived class in same assembly
    private protected int Square(int a)
    {
        return a * a;
    }

    // public method to access private members
    public int GetDifference(int a, int b)
    {
        return Difference(a, b);
    }

    public int GetSquare(int a)
    {
        return Square(a);
    }
}

// Derived class
class AdvancedCalculator : Calculator
{
    public void ShowProtectedMembers()
    {
        Console.WriteLine("Product: " + Product(4, 5));
        Console.WriteLine("Modulus: " + Modulus(10, 3));
        Console.WriteLine("Square: " + GetSquare(6));
    }
}

// Main class
class AccessModifier
{
    static void Main()
    {
        Calculator calc = new Calculator();

        Console.WriteLine("Sum: " + calc.Sum(10, 5));
        Console.WriteLine("Difference: " + calc.GetDifference(10, 5));
        Console.WriteLine("Division: " + calc.Divide(10, 2));
        Console.WriteLine("Modulus: " + calc.Modulus(10, 3));

        AdvancedCalculator adv = new AdvancedCalculator();
        adv.ShowProtectedMembers();
    }
}
