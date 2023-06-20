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

        private List<ComputeEmpWage> companyEmpWageList;
        public EmpWageForMultipleCompanies()
        {
            this.companyEmpWageList = new List<ComputeEmpWage>();
        }

        public void AddCompanyEmpWage(string company, int empWagePerHour, int numOfWorkingDays, int maxHrsInMonth)
        {
            ComputeEmpWage companyEmpWage = new ComputeEmpWage(company, empWagePerHour, numOfWorkingDays, maxHrsInMonth);
            companyEmpWageList.Add(companyEmpWage);
        }

        public void ComputeEmployeeWage()
        {
            foreach (ComputeEmpWage companyEmpWage in companyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(ComputeEmployeeWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
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
                int dailyWage = empHrs * companyEmpWage.empWagePerHour;
                companyEmpWage.AddDailyWage(dailyWage);
                Console.WriteLine("Day is : " + totalWorkingDays + " working hours is " + empHrs+" and daily wage is: "+dailyWage );
            }
            return totalEmpHrs * companyEmpWage.empWagePerHour;
        }
    }
}
