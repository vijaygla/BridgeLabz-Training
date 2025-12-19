using System;

class AllDataTypes
{
    static void Main()
    {
        // Integer types
        int i = 10;
        long l = 100000;
        byte b = 5;

        // Floating point types
        float f = 10.5f;
        double d = 20.25;
        decimal dec = 99.99m;

        // Other value types
        bool isTrue = true;
        char ch = 'A';

        // Reference types
        string name = "Vijay";
        object obj = 123;

        // Output
        Console.WriteLine("Integer: " + i);
        Console.WriteLine("Long: " + l);
        Console.WriteLine("Byte: " + b);

        Console.WriteLine("Float: " + f);
        Console.WriteLine("Double: " + d);
        Console.WriteLine("Decimal: " + dec);

        Console.WriteLine("Boolean: " + isTrue);
        Console.WriteLine("Char: " + ch);

        Console.WriteLine("String: " + name);
        Console.WriteLine("Object: " + obj);
		
		
		// Type casting
		// Two type of casting
		// 1. Implicite casting ---> small --> big || automatic
		int a = 100;
		double b2 = a;
		Console.WriteLine("Implicite Casting: ");
		Console.WriteLine(b2);
		
		// 2. Explicite casting ---> big --> small || manual
		double x = 99.99;
		int y = (int)x;
		Console.WriteLine("Explicite");
		Console.WriteLine(y);
    }
}

