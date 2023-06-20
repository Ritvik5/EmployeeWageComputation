using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public interface IComputeEmpWage
    {
        void AddCompanyEmpWage(string comapny, int empWagePerHour, int numOfWorkingDays, int maxHrsInMonth);
        void ComputeEmpWage();
        int GetTotalWage(string company);
    }
    public  class ComputeEmpWage
    {
        public string company;
        public int empWagePerHour;
        public int numOfWorkingDays;
        public int maxHrsInMonth;
        public int totalEmpWage;

        public ComputeEmpWage(string company, int empWagePerHour, int numOfWorkingDays, int maxHrsInMonth)
        {
            this.company = company;
            this.empWagePerHour = empWagePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrsInMonth = maxHrsInMonth;
            this.totalEmpWage = 0;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string toString()
        {
            return "Total Emp Wage for comapany " + this.company + " is : " + this.totalEmpWage;
        }
    }
}
