using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND1_BasicCorePrograms
{
    internal class PrimeFactors
    {
        public void primeFactors()
        {
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Prime factors of " + num + " are: ");
            for (int i = 2; i < num; i++)
            {
                while (num % i == 0)
                {
                    Console.WriteLine(i + " ");
                    num = num / i;
                }
            }
            if (num > 2)
                Console.WriteLine(num);
        }
    }
}
