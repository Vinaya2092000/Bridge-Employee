using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProblem
{
    public class Employee
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int RATE_PER_HOUR = 29;

        public const int WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;

        public void EmpWage()
        {

            //Variables
            int empHrs;
            int totalEmpHrs = 0, totalWorkingDays = 0;
            //Computation
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {

                    case IS_PART_TIME:
                        empHrs = 4;
                        break;

                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;

                    default:
                        empHrs = 6;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day" + totalWorkingDays + "Emp Hrs " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage: " + totalEmpWage);
        }                                        // DayNumber++;                                                 // TotalWorkingHrs += EmpWorkingHrs;
    }
}
