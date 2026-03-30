using System;

class CanVoteOrNot
{
    static void Main(String[] args)
    {
        int age = Convert.ToInt32(Console.ReadLine());
        
        if(age >= 18) {
            Console.WriteLine("He can give the vote");
        } else {
            Console.WriteLine("He can not give the vote");
        }
    }
}
