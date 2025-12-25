// Rework the program 2, especially the Hint: if index equals maxDigit, we break from the loop. Here we want to modify to increase the size of the array i,e maxDigit by 10 if the index is equal to maxDigit. This is done to consider all digits to find the largest and second-largest number 


using System;

class DynamicLargestDigit {
    static void Main(string[] args) {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;

        while (number != 0) {
            if (index == maxDigit) {
                maxDigit += 10;
                int[] temp = new int[maxDigit];
                for (int i = 0; i < index; i++)
                    temp[i] = digits[i];
                digits = temp;
            }

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
