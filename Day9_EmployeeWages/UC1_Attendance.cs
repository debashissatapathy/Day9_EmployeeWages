using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_EmployeeWages
{
    class UC1_Attendance
    {
        public void Attendance()
        {
            int EmpHr;
            Random random = new Random();
            int emp_check = random.Next(2);
            if (emp_check == 1)
            {
                Console.WriteLine("Employee is present and type FullTIme");
                EmpHr = 8;
            }
            else if (emp_check == 2)
            {
                Console.WriteLine("Employee is present and type PartTIme");
                EmpHr = 4;
            }
            else
                Console.WriteLine("Employee is Absent");
                EmpHr = 0;
        }
    }
}
