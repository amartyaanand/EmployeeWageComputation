using System;

namespace SwitchCaseStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int checkValue = random.Next(2);
            int empDailyWage = 20, empDailyHrs = 0, pEmpDailyHrs = 0;

            switch (checkValue)
            {
                case 0:
                    Console.WriteLine("Employee is Absent.");
                    break;
                case 1:
                    Console.WriteLine("Employee is Present.");
                    break;
                    // default need not to be used
            }

            switch (checkValue)
            {
                case 0:
                    Console.WriteLine("Employee Daily wage is : " + empDailyHrs * empDailyWage);
                    Console.WriteLine("Part time Employee Daily wage is : " + pEmpDailyHrs * empDailyWage);
                    break;
                case 1:
                    empDailyHrs = 8;
                    pEmpDailyHrs = 4;
                    Console.WriteLine("Employee Daily wage is : " + empDailyHrs * empDailyWage);
                    Console.WriteLine("Part time Employee Daily wage is : " + pEmpDailyHrs * empDailyWage);
                    break;
            }
        }
    }
}
