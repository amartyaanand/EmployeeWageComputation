using System;

namespace ConditionalWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int empMonWage = 0, isPresent = 1, empDailyWage = 20, presentDays = 0, absentDays = 0;
            Random random = new Random();
            int checkValue;



            for (int days = 0, hrs = 0; days < 20 && hrs < 100;)
            {
                checkValue = random.Next(2);
                if (checkValue == isPresent)
                {
                    hrs += 8;

                    if (hrs > 100)
                        break;

                    days++;
                    presentDays++;
                    empMonWage += empDailyWage;
                }
                else
                {
                    absentDays++;
                }
            }
            Console.WriteLine($"Employee worked for {presentDays * 8} hours OR {presentDays} days out of {presentDays + absentDays} days");
            Console.WriteLine("Employee wage is : " + empMonWage);
        }
    }
}
