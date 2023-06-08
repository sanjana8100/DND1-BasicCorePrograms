using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND1_BasicCorePrograms
{
    internal class PowerOfTwo
    {
        public void powerOfTwo()
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int powOfTwo = 1;
            Console.WriteLine("*********************************************");
            Console.WriteLine("The table of powers of the 2 are as follows:");
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("   " + i + "  :  " + powOfTwo);
                powOfTwo *= 2;
            }
        }
    }
}
