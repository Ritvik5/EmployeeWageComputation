namespace EmployeeWage
{
    public class Program
    {
        public static void Main(string[] args)
        {
           EmpWageForMultipleCompanies empWage = new EmpWageForMultipleCompanies();
           empWage.AddCompanyEmpWage("DMart", 20, 20, 100);
           empWage.AddCompanyEmpWage("Reliance", 40, 15, 50);
           empWage.ComputeEmployeeWage();
        }
    }
}