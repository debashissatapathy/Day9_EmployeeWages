using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_EmployeeWages
{
    class UC3_PartTime
    {
        public void partTime()
        {

            const int empRatePerHr = 20;
            const int isFullTime = 1;
            const int isPartTime = 2;

            int empWagesPerDay, empHr = 0;
            Random rand = new Random();
            int empCheck = rand.Next(0, 3);
            empWagesPerDay = empHr * empRatePerHr;
            switch (empCheck)
            {
                case 0:
                    Console.WriteLine("Employee is Absent");
                    break;
                case isFullTime:
                    empHr = 8;
                    Console.WriteLine("Present : FullTime Employee");
                    Console.WriteLine("Salary= " + empHr * empRatePerHr);

                    break;
                case isPartTime:
                    empHr = 4;
                    Console.WriteLine("Present : PartTime EMployee");
                    Console.WriteLine("Salary= " + empHr * empRatePerHr);

                    break;
                default:
                    Console.WriteLine("Holiday");
                    break;



            }

        }
    }
}
