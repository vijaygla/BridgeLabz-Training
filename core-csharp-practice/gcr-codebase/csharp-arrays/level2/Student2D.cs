// Rewrite the above program to store the marks of the students in physics, chemistry, and maths in a 2D array and then compute the percentage and grade

using System;

class Student2D {
    static void Main(string[] args) {
        Console.Write("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[,] marks = new double[n, 3];
        double[] percentage = new double[n];
        char[] grade = new char[n];

        for (int i = 0; i < n; i++) {
            Console.Write("Physics: ");
            marks[i, 0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Chemistry: ");
            marks[i, 1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Maths: ");
            marks[i, 2] = Convert.ToDouble(Console.ReadLine());

            percentage[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3;

            if (percentage[i] >= 75) grade[i] = 'A';
            else if (percentage[i] >= 60) grade[i] = 'B';
            else if (percentage[i] >= 40) grade[i] = 'C';
            else grade[i] = 'F';
        }

        for (int i = 0; i < n; i++)
            Console.WriteLine("Percentage: " + percentage[i] + " Grade: " + grade[i]);
    }
}
