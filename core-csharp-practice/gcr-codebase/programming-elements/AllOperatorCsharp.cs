using System;

class AllOperatorCsharp
{
    static void Main()
    {
        // Arithmetic operators
        int num1 = 10;
        int num2 = 4;

        int sum = num1 + num2;
        int difference = num1 - num2;
        int product = num1 * num2;
        int divide = num1 / num2;
        int modulo = num1 % num2;

        Console.WriteLine("Arithmetic Operators");
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Difference: " + difference);
        Console.WriteLine("Product: " + product);
        Console.WriteLine("Divide: " + divide);
        Console.WriteLine("Modulo: " + modulo);

        // Relational (Comparison) operators
        Console.WriteLine("\nRelational (Comparison) Operators");
        Console.WriteLine("== operator: " + (num1 == num2));
        Console.WriteLine("!= operator: " + (num1 != num2));
        Console.WriteLine("> operator: " + (num1 > num2));
        Console.WriteLine("< operator: " + (num1 < num2));
        Console.WriteLine(">= operator: " + (num1 >= num2));
        Console.WriteLine("<= operator: " + (num1 <= num2));

        // Logical Operators (need boolean values)
        bool a = true;
        bool b = false;

        Console.WriteLine("\nLogical Operators");
        Console.WriteLine("&& operator: " + (a && b));
        Console.WriteLine("|| operator: " + (a || b));
        Console.WriteLine("! operator: " + (!a));

        // Assignment operators
        Console.WriteLine("\nAssignment Operators");
        int x = 10;
        x += 5;
        Console.WriteLine("+= operator: " + x);
        x -= 3;
        Console.WriteLine("-= operator: " + x);
        x *= 2;
        Console.WriteLine("*= operator: " + x);
        x /= 4;
        Console.WriteLine("/= operator: " + x);
        x %= 3;
        Console.WriteLine("%= operator: " + x);

        // Unary operators
        Console.WriteLine("\nUnary Operators");
        int y = 5;
        Console.WriteLine("++ operator: " + (++y));
        Console.WriteLine("-- operator: " + (--y));

        // Bitwise Operators
        Console.WriteLine("\nBitwise Operators");
        Console.WriteLine("& operator: " + (num1 & num2));
        Console.WriteLine("| operator: " + (num1 | num2));
        Console.WriteLine("^ operator: " + (num1 ^ num2));
        Console.WriteLine("~ operator: " + (~num1));
        Console.WriteLine("<< operator: " + (num1 << 1));
        Console.WriteLine(">> operator: " + (num1 >> 1));

        // Special operator: is
        Console.WriteLine("\nIs Operator");
        if (num1 is int)
        {
            Console.WriteLine("num1 is integer");
        }
    }
}
