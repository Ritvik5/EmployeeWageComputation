namespace EmployeeWage
{
    public class Program
    {
        static void Main(string[] args)
        {
            int isFullTime = 1;
            int isPartTime = 2;
            int empWagePerHour = 20;

            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            int empCheck = random.Next(0,3);

            switch (empCheck)
            {
                case 1:
                    empHrs = 8;
                    break;
                case 2:
                    empHrs = 4;
                    break;
                default: 
                    empWage = 0; 
                    break;
            }
            empWage = empHrs * empWagePerHour;
            Console.WriteLine("Daily Employee Wage is " +empWage);
        }
    }
}