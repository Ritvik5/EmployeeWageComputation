using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public  class ComputeEmpWage
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;

        private string company;
        private int empWagePerHour;
        private int numOfWorkingDays;
        private int maxHrsInMonth;
        private int totalEmpWage;


        public ComputeEmpWage(string company, int empWagePerHour, int numOfWorkingDays, int maxHrsInMonth)
        {
            this.company = company;
            this.empWagePerHour = empWagePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrsInMonth = maxHrsInMonth;

        }

        public void ComputeEmployeeWage()
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= maxHrsInMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case isFullTime:
                        empHrs = 8;
                        break;
                    case isPartTime:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day is : " + totalWorkingDays  +" and working hours is " + empHrs );
            }
            totalEmpWage = totalEmpHrs * this.empWagePerHour;
            Console.WriteLine("Total Employee Wage for company " + company + " is " + totalEmpWage);
        }
    }
}
