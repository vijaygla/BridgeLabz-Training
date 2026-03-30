using System;

class Mathematical{
    static void Main(){
        Console.WriteLine("Mathmetical operation");
        Console.WriteLine("1.Factorial 2.Prime 3.GCD 4.Fibonacci");
        Console.Write("Choice: ");
        string choice = Console.ReadLine();

        if(choice == "1"){
            Console.Write("Number: "); int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial: " + Factorial(n));
        }
        else if(choice == "2"){
            Console.Write("Number: "); int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Prime: " + Prime(n));
        }
        else if(choice == "3"){
            Console.Write("Num1: "); int a = int.Parse(Console.ReadLine());
            Console.Write("Num2: "); int b = int.Parse(Console.ReadLine());
            Console.WriteLine("GCD: " + GCD(a, b));
        }
        else if(choice == "4"){
            Console.Write("Position: "); int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Fibonacci: " + Fibonacci(n));
        }
    }

    static int Factorial(int n){
        if(n < 0) return 0;
        int fact = 1;
        for(int i = 1; i <= n; i++){
            fact *= i;
        }
        return fact;
    }

    static bool Prime(int n){
        if(n <= 1) return false;
        int count = 0;
        for(int i = 1; i <= n; i++){
            if(n % i == 0) count++;
        }
        return count == 2;
    }

    static int GCD(int a, int b){
        if(a == 0) return b;
        if(b == 0) return a;
        while(a != b){
            if(a > b) a -= b;
            else b -= a;
        }
        return a;
    }

    static int Fibonacci(int n){
        if(n == 0) return 0;
        if(n == 1) return 1;
        int first = 0;
        int second = 1;
        for(int i = 2; i <= n; i++){
            int next = first + second;
            first = second;
            second = next;
        }
        return second;
    }
}
