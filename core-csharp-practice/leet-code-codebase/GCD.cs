using System;

class GCD {
    static void Main(String[] args) {
        Console.Write("Enter num1: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter num2: ");
        int num2 = int.Parse(Console.ReadLine());
        int ans = Gcd(num1, num2);
        Console.WriteLine("GCD: " + ans);
    }

    static int Gcd(int a, int b) {
        while(b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
