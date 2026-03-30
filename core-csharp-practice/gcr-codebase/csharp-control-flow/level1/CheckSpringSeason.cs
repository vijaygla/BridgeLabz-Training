using System;

class CheckSpringSeason {
    static void Main(String[] args) {
        Console.Write("Enter Month: ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Day: ");
        int day = Convert.ToInt32(Console.ReadLine());

        if ((month == 3 && day >= 20) ||
            (month == 4) ||
            (month == 5) ||
            (month == 6 && day <= 20))
        {
            Console.WriteLine("Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }
}
