using System;

class VotingEligibility {
    static void Main(String[] args) {
        int[] age = new int[10];

        for(int i=0; i < age.Length; i++) {
            Console.Write("Enter age " + (i + 1) + ": ");
            age[i] = int.Parse(Console.ReadLine());
        }

        for(int i=0; i<age.Length; i++) {
            Console.Write("age " + (i+1) + ": ");
            if(age[i] >= 18) {   // if age greater than the 18 or equal to 18 than he/she can vote
                Console.WriteLine("Can Vote");
            }
            else {
                Console.WriteLine("Can not Vote");
            }
        }
    }
}

