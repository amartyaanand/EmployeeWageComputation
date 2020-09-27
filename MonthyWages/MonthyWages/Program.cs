using System;

namespace MonthyWages
{
    class Program
    {
        static void Main(string[] args)
        {
            int empMonWage = 0, isPresent = 1, empDailyHrs = 8, empDailyWage = 20, presentDays = 0, absentDays = 0;
            Random random = new Random();
            int checkValue;

            for (int i = 0; i < 20; i++)
            {
                //using random to check employees daily attendance
                checkValue = random.Next(2);
                if (checkValue == isPresent)
                {
                    presentDays++;
                    empMonWage += empDailyWage * empDailyHrs;
                }
                else
                    absentDays++;
            }
            Console.WriteLine($"Employee Attendance \nTotal working days per month 20 \nPresent for {presentDays} \nAbsent for {absentDays}");
            Console.WriteLine("Employee's monthly wage is : " + empMonWage);
        }
    }
}
