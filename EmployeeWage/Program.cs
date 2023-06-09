namespace EmployeeWage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ComputeEmpWage reliance = new ComputeEmpWage("Reliance",20,20,100);
            reliance.ComputeEmployeeWage();
            ComputeEmpWage dMart = new ComputeEmpWage("Dmart", 20, 15, 180);
            dMart.ComputeEmployeeWage();
        }
    }
}