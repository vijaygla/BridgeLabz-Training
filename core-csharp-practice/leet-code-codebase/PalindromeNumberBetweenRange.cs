using System;

class PalindromeNumberBetweenRange {
    static void Main(String[] args) {
        Console.Write("Enter any number to start: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter any number to end: ");
        int end = int.Parse(Console.ReadLine());
        
        for(int i=start; i<=end; i++) {
            int n = i;
            int reverse = 0;

            while(n > 0) {
                int rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;
            }

            if(i == reverse) {
                Console.WriteLine(i + " ");
            }
        }
    }
}
