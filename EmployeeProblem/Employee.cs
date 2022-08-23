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
        public void EmpWage()
        {
            Random empCheck = new Random(); //Random=class random=obj
            int value = empCheck.Next(0, 2); //next=method

            if (value == EmpPresent)
            {
                Console.WriteLine("Employee Present");
            }

            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
