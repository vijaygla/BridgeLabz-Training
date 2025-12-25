using System;

class PalindromeNumber {
    static void Main(String[] args) {
        Console.Write("Enter any number to check the palindrome: ");
        int n = int.Parse(Console.ReadLine());
        int reverse = 0;
        int originalNumber = n;

        while(n > 0) {
            int rem = n % 10;
            reverse = reverse * 10 + rem;
            n = n / 10;
        }
        
        if(reverse == originalNumber) {
            Console.WriteLine("Pallindrome");
        }
        else {
            Console.WriteLine("Not Pallindrome");
        }
    }
}
