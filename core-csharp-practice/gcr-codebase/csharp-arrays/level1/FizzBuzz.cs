// Write a program FizzBuzz, take a number as user input and if it is a positive integer loop from 0 to the number and save the number, but for multiples of 3 save "Fizz" instead of the number, for multiples of 5 save "Buzz", and for multiples of both save "FizzBuzz". Finally, print the array results for each index position in the format Position 1 = 1, …, Position 3 = Fizz,...

using System;

class FizzBuzz {
    static void Main(string[] args) {
        Console.Write("Enter a positive number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0) {
            Console.WriteLine("Invalid input");
            return;
        }

        string[] ans = new string[number + 1];

        for (int i = 1; i <= number; i++) {
            if (i % 3 == 0 && i % 5 == 0)
                ans[i] = "FizzBuzz";
            else if (i % 3 == 0)
                ans[i] = "Fizz";
            else if (i % 5 == 0)
                ans[i] = "Buzz";
            else
                ans[i] = i.ToString();
        }

        for (int i = 1; i <= number; i++) {
            Console.WriteLine("Position " + i + " = " + ans[i]);
        }
    }
}
