namespace EmployeeWage
{
    public class Program
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public const int empWagePerHour = 20;
        public const int numOfWorkingDays = 20;

        public static void Main(string[] args)
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage =0;
            for (int i = 0; i <= numOfWorkingDays; i++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
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
                totalEmpWage += empWage;
            }
            Console.WriteLine("Monthly Employee Wage is " + totalEmpWage);
        }
    }
}