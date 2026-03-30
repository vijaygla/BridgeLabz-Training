using System;

class RocketCountDown {
    static void Main(String[] args) {
        Console.Write("Enter any positive number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if(num < 0) {
            Console.WriteLine("Enter any positive number");
        }

        while(num > 0) {
            Console.WriteLine(num);
            num--;
        }

        Console.Write("Rocket Launch");
    }
}

