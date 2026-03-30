// Create a program to store the digits of the number in an array and find the largest and second largest element of the array.

using System;

class LargestDigit {
    static void Main(string[] args) {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;

        while (number != 0 && index < maxDigit) {
            digits[index++] = number % 10;
            number /= 10;
        }

        int largest = 0, secondLargest = 0;

        for (int i = 0; i < index; i++) {
            if (digits[i] > largest) {
                secondLargest = largest;
                largest = digits[i];
            } else if (digits[i] > secondLargest && digits[i] != largest) {
                secondLargest = digits[i];
            }
        }

        Console.WriteLine("Largest = " + largest);
        Console.WriteLine("Second Largest = " + secondLargest);
    }
}
