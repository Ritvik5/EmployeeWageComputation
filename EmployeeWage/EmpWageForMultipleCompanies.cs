using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmpWageForMultipleCompanies : IComputeEmpWage
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;

        private LinkedList<ComputeEmpWage> companyEmpWageList;
        private Dictionary<string, ComputeEmpWage> companyToEmpWageMap;

        public EmpWageForMultipleCompanies()
        {
            this.companyEmpWageList = new LinkedList<ComputeEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, ComputeEmpWage>();
        }

        public void AddCompanyEmpWage(string company, int empWagePerHour, int numOfWorkingDays, int maxHrsInMonth)
        {
            ComputeEmpWage companyEmpWage = new ComputeEmpWage(company, empWagePerHour, numOfWorkingDays, maxHrsInMonth);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);
        }

        public void ComputeEmpWage()
        {
            foreach (ComputeEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(this.ComputeEmployeeWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }

        public int GetTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWage;
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
                Console.WriteLine("Day is : " + totalWorkingDays + " working hours is " + empHrs );
            }
            return totalEmpHrs * companyEmpWage.empWagePerHour;
        }
    }
}
