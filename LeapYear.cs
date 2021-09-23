using System;
namespace Year
{
    class LeapYear
    {
        int head = 0;
        int tail = 1;
        int headCount = 0;
        int tailCount = 0;
        void leap()
        {
            Console.WriteLine("Enter Year : ");
            String year = Console.ReadLine();
            int length = year.Length;
            if (length == 4)
            {
                int year2 = Convert.ToInt32(year);
                if (year2 % 4 == 0)
                    Console.WriteLine(year2 + " is Leap Year");
                else
                    Console.WriteLine(year2 + " is not Leap Year");
            }
            else
            {
                Console.WriteLine("Please Enter Valid 4 Digit Year");
                leap();
            }
        }
            static void Main(string[] args)
            {
            LeapYear obj = new LeapYear();
            obj.leap();
            }
    }

} 