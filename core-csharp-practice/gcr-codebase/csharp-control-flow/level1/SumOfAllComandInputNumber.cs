// Write a program to find the sum of numbers until the user enters 0.

using System;

class SumOfAllCommandInputNumber {
    static void Main(String[] args) {
        
        int sum = 0;

        while(true) {
            Console.Write("Enter any number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if(n == 0) break;
            sum += n;
        }

        Console.WriteLine("Sum of all the input given by the command prompt: " + sum);
    }
}
