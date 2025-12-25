using System;

class MultiplicationTable {
    static void Main(String[] args) {
        Console.Write("Enter any number: ");
        int n = int.Parse(Console.ReadLine());

        for(int i=1; i<=10; i++) {
            Console.WriteLine(n + " * " + i + " = " + (n*i));
        }
    }
}
