// Create a program to save odd and even numbers into odd and even arrays between 1 to the number entered by the user. Finally, print the odd and even numbers array

using System;

class OddEvenArray {
    static void Main(String[] args) {
        Console.Write("Enter a natural number: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0) {
            Console.WriteLine("Invalid input");
            return;
        }

        int[] even = new int[n / 2 + 1];
        int[] odd = new int[n / 2 + 1];

        int eIndex = 0, oIndex = 0;

        for (int i = 1; i <= n; i++) {
            if (i % 2 == 0) {
                even[eIndex++] = i;
            }
            else {
                odd[oIndex++] = i;
            }
        }

        Console.WriteLine("Odd Numbers:");
        for (int i = 0; i < oIndex; i++) {
            Console.Write(odd[i] + " ");
        }
        
        Console.WriteLine("\nEven Numbers:");
        for (int i = 0; i < eIndex; i++) {
            Console.Write(even[i] + " ");
        }
    }
}
