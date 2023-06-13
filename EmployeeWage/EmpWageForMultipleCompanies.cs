using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmpWageForMultipleCompanies
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;

        private int numOfCompany = 0;
        private ComputeEmpWage[] companyEmpWageArray;

        public EmpWageForMultipleCompanies()
        {
            this.companyEmpWageArray = new ComputeEmpWage[5];
        }

        public void AddCompanyEmpWage(string company, int empWagePerHour, int numOfWorkingDays, int maxHrsInMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new ComputeEmpWage(company, empWagePerHour, numOfWorkingDays, maxHrsInMonth);
            numOfCompany++;
        }

        public void ComputeEmployeeWage()
        {
            for(int i = 0;i < numOfCompany;i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.ComputeEmployeeWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }

        public int ComputeEmployeeWage(ComputeEmpWage companyEmpWage)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= companyEmpWage.maxHrsInMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
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
                Console.WriteLine("Day is : " + totalWorkingDays + " and working hours is " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empWagePerHour;
        }
    }
}
