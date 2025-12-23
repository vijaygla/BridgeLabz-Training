using System;

class SumOfNNaturalNumber {
    static void Main(String[] args) {
        Console.Write("Enter any number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int sum_2 = (n * (n+1)) / 2;

        while(n >= 0) {
            sum += n;
            n--;
        }

        Console.WriteLine("Sum of natural number: " + sum);

        
        if(sum == sum_2) {
            Console.Write("Both value are equal");
        }
        else {
            Console.Write("not equal");
        }
    }
}
