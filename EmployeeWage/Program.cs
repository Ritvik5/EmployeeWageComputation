namespace EmployeeWage
{
    public class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 1;
            int empWagePerHour = 20;

            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            int empCheck = random.Next(0,2);

            if (empCheck == isPresent )
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * empWagePerHour;
            Console.WriteLine("Daily Employee Wage is " +empWage);
        }
    }
}