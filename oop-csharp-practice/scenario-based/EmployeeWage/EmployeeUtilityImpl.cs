using EmployeeWage;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    internal class EmployeeUtilityImpl : IEmployee
    {
        public void CheckAttendance()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch");

            Random random = new Random();
            int attendance = random.Next(0, 2);

            if (attendance == 1)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }

    }
}
