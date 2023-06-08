using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND1_BasicCorePrograms
{
    internal class SwapTwoNumbers
    {
        public void swapTwoNumbers()
        {
            Console.WriteLine("Enter two numbers:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*********************************************************");
            Console.WriteLine("The Original values of the two numbers are:");
            Console.WriteLine("Number1: " + num1 + "     Number2: " + num2);
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("The values of the two numbers after swapping:");
            Console.WriteLine("Number1: " + num1 + "     Number2: " + num2);
        }
    }
}
