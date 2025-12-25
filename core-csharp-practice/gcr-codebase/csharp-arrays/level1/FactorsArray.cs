// Create a program to find the factors of a number taken as user input, store the factors in an array, and display the factors

using System;

class FactorsArray {
    static void Main(string[] args) {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int maxSize = 10;
        int[] factors = new int[maxSize];
        int index = 0;

        for (int i = 1; i <= number; i++) {
            if (number % i == 0) {
                if (index == maxSize) {
                    maxSize *= 2;
                    int[] temp = new int[maxSize];
                    for (int j = 0; j < index; j++)
                        temp[j] = factors[j];
                    factors = temp;
                }
                factors[index++] = i;
            }
        }

        Console.WriteLine("Factors:");
        for (int i = 0; i < index; i++)
            Console.Write(factors[i] + " ");
    }
}
