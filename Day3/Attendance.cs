using System;
namespace wage
{
    class Attendance
    {
        void emp()
        {
            Random rand = new Random();
            int attendance = rand.Next();
            attendance = attendance % 2;
            
            if (attendance == 1)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
        static void Main(string[] args)
        {
            Program aa = new Program();
            aa.emp();
        }
    }
        
}