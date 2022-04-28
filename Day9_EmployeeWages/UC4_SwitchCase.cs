using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_EmployeeWages
{
    class UC4_SwitchCase
    {
        public static void Check_Employee()
        {

            int empWageperHr = 20;
            int fullTimeHr = 8;
            int partTimeHr = 4;
            
            int empWagesPerDay;
            Random rand = new Random();
            int empCheck = rand.Next(0, 4);

            switch (empCheck)
            {
                case 0:
                    Console.WriteLine("Employee is Absent");
                    break;
                case 1:
                    empWagesPerDay = fullTimeHr * empWageperHr;
                    Console.WriteLine("Present : FullTime Employee");
                    Console.WriteLine("Per day Salary : " + empWagesPerDay);
                    
                    break;
                case 2:
                    empWagesPerDay = partTimeHr * empWageperHr;
                    Console.WriteLine("Present : PartTime EMployee");
                    Console.WriteLine("Salary : " + empWagesPerDay);
                    
                    break;

                default:
                    Console.WriteLine("Error");
                    break;

            }
        }
    }
}
