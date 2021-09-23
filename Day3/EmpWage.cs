using System;
namespace wage
{
    class EmpWage
    {
        void emp()
        {
            int totalHour = 8;
            int empWagePerHour = 200;
            Random rand = new Random();
            int attendance = rand.Next();
            attendance = attendance % 2;
            
            if (attendance == 1)
            {
                int totalWage = totalHour * empWagePerHour;
                Console.WriteLine("Employee is present");
                Console.WriteLine("Wage : " + totalWage);
            }
            else
            {
                Console.WriteLine("Employee is absent");
                Console.WriteLine("No Wage Calculated");
            }
        }
        static void Main(string[] args)
        {
            Program aa = new Program();
            aa.emp();
        }
    }
        
}