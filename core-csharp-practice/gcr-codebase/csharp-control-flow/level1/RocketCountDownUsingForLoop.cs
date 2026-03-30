using System;

class RocketCountDownUsingForLoop {
    static void Main(String[] args) {
        Console.Write("Enter any positive number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        for(int i=num; i>=1; i--) {
            Console.WriteLine(i);
        }
        Console.Write("Rocket Lunch");
    }
}
