using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_EmployeeWages
{
    class UC4_MonthlySalary
    {
        public void Total_Time()
        {
            int empRateperHr = 20;
            int fullDayHr = 8;
            int Working_Day = 20;
            int per_mon_sal_full = (empRateperHr * fullDayHr * Working_Day);
            int per_mon_sal_part = (empRateperHr * (fullDayHr / 2) * Working_Day);
            int i;
            Console.WriteLine("Job Type For Monthly salary :");
            string empType = Console.ReadLine();
            switch (empType)
            {
                case "FullTime":
                    Console.WriteLine("MOnthly salary for full Time :" + per_mon_sal_full);
                    break;
                case "PartTime":
                    Console.WriteLine("MOnthly salary for part Time :" + per_mon_sal_part);
                    break;
            }
        }
    }
}
