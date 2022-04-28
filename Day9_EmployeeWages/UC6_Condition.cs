using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_EmployeeWages
{
    class UC6_Condition
    {
        public void Total_Time()
        {
            int empWageperHr = 20;
            int fullTimeWorkingHr = 8;
            int partTimeWorkingHr = 4;
            int totalWorkHr = 100;
            int Working_Day = 20;
            int perDaySalary, monthlySalary = 0, dayCount = 1;
            Console.WriteLine("Job Type For Monthly salary :");
            string empType = Console.ReadLine();
            switch (empType)
            {
                case "FullTime":
                    while (totalWorkHr > 0 && (totalWorkHr / fullTimeWorkingHr) >= 0 && dayCount <= Working_Day)
                    {
                        perDaySalary = fullTimeWorkingHr * empWageperHr;
                        monthlySalary += perDaySalary;
                        Console.WriteLine("Salary of " + empType + " on day " + dayCount + " is: " + perDaySalary);
                        Console.WriteLine("Monthly Salary till date: " + monthlySalary);
                        totalWorkHr -= fullTimeWorkingHr;
                        dayCount++;
                    }
                    break;
                case "PartTime":
                    while (totalWorkHr > 0 && (totalWorkHr / partTimeWorkingHr) >= 0 && dayCount <= Working_Day)
                    {
                        perDaySalary = partTimeWorkingHr * empWageperHr;
                        monthlySalary += perDaySalary;
                        Console.WriteLine("Salary of " + empType + " on day " + dayCount + " is: " + perDaySalary);
                        Console.WriteLine("Monthly Salary till date: " + monthlySalary);
                        totalWorkHr -= partTimeWorkingHr;
                        dayCount++;
                    }
                    break;
            }
        }
    }
}
