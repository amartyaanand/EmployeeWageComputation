using System;

namespace EmployeeAttendance
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 1;

            Random random = new Random();
            int checkVariable = random.Next(2);

            if (checkVariable == isPresent)
                Console.WriteLine("Employee is Present.");
            else
                Console.WriteLine("Employee is Absent.");
        }
    }
}
