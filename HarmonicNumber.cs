using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND1_BasicCorePrograms
{
    internal class HarmonicNumber
    {
        public void harmonicNumber()
        {
            Console.WriteLine("Enter a Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            float harmonic_value = 1;
            for (int i = 2; i <= num; i++)
            {
                harmonic_value = harmonic_value + (float)1 / i;
            }
            Console.WriteLine("The Nth Harmonic Value where N=" + num + " is: " + harmonic_value);
        }
    }
}
