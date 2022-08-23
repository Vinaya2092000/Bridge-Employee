using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProblem
{
    public class Employee
    {
        public int EmpPresent = 1;
        public int FullTime = 1;
        public int Wage_Per_Hr = 20;
        public int Full_Day_Hr = 8;
        public int PartTime_Day_Hr = 4;
        public int DailyWage = 0;
        public void EmpWage()
        {
            Random empCheck = new Random(); //Random=class random=obj
            int value = empCheck.Next(0, 2); //next=method

            if (value == EmpPresent)
            {
                Random TimeCheck = new Random();
                int WorkingHours = TimeCheck.Next(0, 2);
                if (WorkingHours == FullTime)
                {
                    DailyWage = Wage_Per_Hr * Full_Day_Hr;
                    Console.WriteLine("Employee Present" + DailyWage);
                }
                else
                {
                    DailyWage = Wage_Per_Hr * PartTime_Day_Hr;
                    Console.WriteLine("Employee Present for PartTime" + DailyWage);
                }
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }       // TotalWorkingHrs += EmpWorkingHrs;
    }
}
