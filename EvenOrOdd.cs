using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND1_BasicCorePrograms
{
    internal class EvenOrOdd
    {
        public void evenOrOdd()
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*******************************************");
            if (num % 2 == 0)
                Console.WriteLine(num + " is a EVEN number.");
            else
                Console.WriteLine(num + " is an ODD number.");
        }
    }
}
