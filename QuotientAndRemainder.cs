using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND1_BasicCorePrograms
{
    internal class QuotientAndRemainder
    {
        public void quotientAndRemainder()
        {
            Console.WriteLine("Enter the Dividend and the Divisor:");
            int dividend = Convert.ToInt32(Console.ReadLine());
            int divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("********************************");
            Console.WriteLine("The Quotient is: " + quotient);
            Console.WriteLine("The Remainder is: " + remainder);
        }
    }
}
