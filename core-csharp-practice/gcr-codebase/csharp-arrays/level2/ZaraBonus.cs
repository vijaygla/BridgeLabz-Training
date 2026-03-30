// Create a program to find the bonus of 10 employees based on their years of service and the total bonus amount the company Zara has to pay, along with the old and new salary.

using System;

class EmployeeBonus {
    static void Main(string[] args) {
        // declare all the array in double datatypes
        double[] salary = new double[10];
        double[] service = new double[10];
        double[] bonus = new double[10];
        double[] newSalary = new double[10];

        double totalBonus = 0, totalOldSalary = 0, totalNewSalary = 0;

        for (int i = 0; i < 10; i++) {
            Console.Write("Enter salary of employee " + (i + 1) + ": ");
            salary[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter years of service: ");
            service[i] = Convert.ToDouble(Console.ReadLine());

            if (salary[i] <= 0 || service[i] < 0) {
                Console.WriteLine("Invalid input, enter again");
                i--;
            }
        }

        for (int i = 0; i < 10; i++) {
            if (service[i] > 5)
                bonus[i] = salary[i] * 0.05;
            else
                bonus[i] = salary[i] * 0.02;

            newSalary[i] = salary[i] + bonus[i];

            totalBonus += bonus[i];
            totalOldSalary += salary[i];
            totalNewSalary += newSalary[i];
        }

        Console.WriteLine("Total Bonus = " + totalBonus);
        Console.WriteLine("Total Old Salary = " + totalOldSalary);
        Console.WriteLine("Total New Salary = " + totalNewSalary);
    }
}
