using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_EmployeeWages
{
    class UC8_MultipleCompany
    {
        public const int IsFullTime = 0;
        public const int IsPartTime = 1;


        public static int Multiple_Company(string Company, int WagePerHr)
        {
            int DayInMonth = 20, HrInMonth = 100;
            int fullTimeWorkingHr = 8;
            int partTimeWorkingHr = 4;
            int DailyWage, Monthly_Wage = 0, day_Count = 1;
            Random random = new Random();
            int chk_EMp = random.Next(0, 4);
            switch (chk_EMp)
            {
                case IsFullTime:
                    while (HrInMonth > 0 && (HrInMonth / fullTimeWorkingHr) >= 0 && day_Count <= DayInMonth)
                    {
                        DailyWage = WagePerHr * fullTimeWorkingHr;
                        Monthly_Wage += DailyWage;
                        Console.Write(Company + " FullTime employee " + day_Count + "st day of wage is: " + DailyWage + "."
                            + " and monthly salary till date is " + Monthly_Wage + "\n");
                        HrInMonth -= fullTimeWorkingHr;
                        day_Count++;
                    }
                    break;
                case IsPartTime:
                    while (HrInMonth > 0 && (HrInMonth / partTimeWorkingHr) >= 0 && day_Count <= DayInMonth)
                    {
                        DailyWage = WagePerHr * partTimeWorkingHr;
                        Monthly_Wage += DailyWage;
                        Console.Write(Company + " PartTime employee " + day_Count + "st day of wage is: " + DailyWage + "."
                            + " and monthly salary till date is " + Monthly_Wage + "\n");
                        HrInMonth -= partTimeWorkingHr;
                        day_Count++;
                    }
                    break;
                case 3:
                    Console.Write("EMployee is absent.");
                    break;

            }

            Console.WriteLine("total Emp Wage: " + Monthly_Wage);
            return Monthly_Wage;

        }

    }
}
