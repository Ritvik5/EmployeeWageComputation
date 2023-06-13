namespace EmployeeWage
{
    public class Program
    {
        public static void Main(string[] args)
        {
           EmpWageForMultipleCompanies empWageBuilder = new EmpWageForMultipleCompanies();
           empWageBuilder.AddCompanyEmpWage("DMart", 20, 20, 100);
           empWageBuilder.AddCompanyEmpWage("Reliance", 40, 15, 50);
           empWageBuilder.ComputeEmployeeWage();
        }
    }
}