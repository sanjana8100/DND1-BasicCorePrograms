using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND1_BasicCorePrograms
{
    internal class LargestOfThree
    {
        public void largestOfThree()
        {
            Console.WriteLine("Enter the values for a,b and c:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***********************************");
            Console.WriteLine("The values entered are:");
            Console.WriteLine("a:" + a + "  b:" + b + "  c:" + c);
            if (a >= b && a >= c)
                Console.WriteLine(a + " is the Largest number.");
            else if (b >= a && b >= c)
                Console.WriteLine(b + " is the Largest number.");
            else
                Console.WriteLine(c + " is the Largest number.");
        }
    }
}
