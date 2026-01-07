using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    sealed class EmployeeMenu
    {
        private IEmployee employeeUtility;

        public EmployeeMenu()
        {
            employeeUtility = new EmployeeUtilityImpl();
        }

        public void Start()
        { 
            employeeUtility.CheckAttendance(); //UC-0
            employeeUtility.CalculateDailyWage(); //UC-1
        }

    }
}
