using System;

class ArmstromNumber {
    static void Main(String[] args) {
        Console.Write("Enter any number to check the armstrom: ");
        int n = int.Parse(Console.ReadLine());
        int originalNumber = n;
        int sum = 0;

        while(n > 0) {
            int lastDigit = n % 10;
            sum = sum + (lastDigit * lastDigit * lastDigit);
            n = n / 10;
        }
        if(sum == originalNumber) {
            Console.WriteLine("Armstrom number");
        }
        else {
            Console.WriteLine("Not Armstrom Number");
        }
    }
}
