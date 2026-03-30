// Create a program to take a number as input find the frequency of each digit in the number using an array and display the frequency of each digit

using System;

class DigitFrequency {
    static void Main(string[] args) {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] freq = new int[10];

        while (number != 0) {
            int digit = number % 10;
            freq[digit]++;
            number /= 10;
        }

        for (int i = 0; i < 10; i++) {
            if (freq[i] > 0)
                Console.WriteLine("Digit " + i + " occurs " + freq[i] + " times");
        }
    }
}
