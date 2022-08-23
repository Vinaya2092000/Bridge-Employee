using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProblem
{
    internal class Employee
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int IS_ABSENT = 0;

        public const int DailyWage = 0;
        //public float TotalMage = 0;
        int Empwage = 20;
        public int IsEmployeePresent()
        {
            return new Random().Next(0, 3);
        }

        //Randon random= new Randon); 
        //int value = ranoda.next(0,3)
        public void EmpWage()
        {

            // int DayNumber = 1;
            int EmpworkingHrs = 0;
            //int TotalworkingHrs = 0;

            switch (IsEmployeePresent())
            {
                case IS_ABSENT:
                    EmpworkingHrs = 0;
                    break;

                case IS_PART_TIME:
                    EmpworkingHrs = 4;
                    break;


                case IS_FULL_TIME:
                    EmpworkingHrs = 8;
                    break;

            }
            int DailyWage = EmpworkingHrs * Empwage; //TotalMage + EmpDailywage;
            Console.WriteLine("Daily Wage: " + DailyWage);                                         // DayNumber++;                                                 // TotalWorkingHrs += EmpWorkingHrs;
        }
    }
}
