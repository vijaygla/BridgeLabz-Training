// Create a program to take a number as input and reverse the number. To do this, store the digits of the number in an array and display the array in reverse order


using System;

class ReverseNumber {
    static void Main(string[] args) {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int temp = number, count = 0;
        while (temp != 0) {
            count++;
            temp /= 10;
        }

        int[] digits = new int[count];
        int[] reverse = new int[count];

        for (int i = 0; i < count; i++) {
            digits[i] = number % 10;
            number /= 10;
        }

        for (int i = 0; i < count; i++)
            reverse[i] = digits[i];

        Console.Write("Reversed Number: ");
        for (int i = 0; i < count; i++)
            Console.Write(reverse[i]);
    }
}
