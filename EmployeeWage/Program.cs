namespace EmployeeWage
{
    public class Program
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public const int empWagePerHour = 20;
        public const int numOfWorkingDays = 20;
        public const int maxHrsInMonth = 100;

        public static void Main(string[] args)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalEmpWage = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= maxHrsInMonth && totalWorkingDays < numOfWorkingDays)
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
            }
            totalEmpWage = totalEmpHrs * empWagePerHour;
            Console.WriteLine("Monthly Employee Wage is " + totalEmpWage);
        }
    }
}