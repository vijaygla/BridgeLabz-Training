using System;

class CheckNumberPositive {
    static void Main(String[] args) {
        Console.WriteLine("Enter any number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num < 0) {
            Console.WriteLine("Number is negative"); 
        } else if(num == 0) {
            Console.WriteLine("Number is equal to zero");
        }
        else {
            Console.WriteLine("Number is Positive");
        }
    }
}
