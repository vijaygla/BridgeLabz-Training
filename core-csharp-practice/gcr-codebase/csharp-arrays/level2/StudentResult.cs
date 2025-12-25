// Create a program to take input marks of students in 3 subjects physics, chemistry, and maths. Compute the percentage and then calculate the grade  as per the following guidelines 


using System;

class StudentResult {
    static void Main(string[] args) {
        Console.Write("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[] percentage = new double[n];
        char[] grade = new char[n];

        for (int i = 0; i < n; i++) {
            Console.Write("Physics: ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Chemistry: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Maths: ");
            double m = Convert.ToDouble(Console.ReadLine());

            percentage[i] = (p + c + m) / 3;

            if (percentage[i] >= 75) grade[i] = 'A';
            else if (percentage[i] >= 60) grade[i] = 'B';
            else if (percentage[i] >= 40) grade[i] = 'C';
            else grade[i] = 'F';
        }

        for (int i = 0; i < n; i++)
            Console.WriteLine("Percentage: " + percentage[i] + " Grade: " + grade[i]);
    }
}
