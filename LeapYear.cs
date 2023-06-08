using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND1_BasicCorePrograms
{
    internal class LeapYear
    {
        public void leapYear() 
        {
            Console.WriteLine("Enter a year:");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year >= 1000 && year < 10000)
            {
                if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                {
                    Console.WriteLine("It is a Leap Year");
                }
                else
                {
                    Console.WriteLine("It is not a Leap Year");
                }
            }
            else
                Console.WriteLine("!!!Enter a valid year!!!");
        }
    }
}
