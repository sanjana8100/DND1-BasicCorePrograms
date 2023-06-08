using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND1_BasicCorePrograms
{
    internal class FlipCoin
    {
        public void flipCoin()
        {
            Console.WriteLine("Enter the number of times you want to flip the coin: ");
            int numberOfFlips = Convert.ToInt32(Console.ReadLine());

            double head = 0, tail = 0;
            if (numberOfFlips > 0)
            {
                for (int i = 0; i <= numberOfFlips; i++)
                {
                    Random random = new Random();
                    double randomNumber = random.NextDouble();
                    if (randomNumber < 0.5)
                    {
                        head++;
                    }
                    else
                    {
                        tail++;
                    }
                }
            }

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("The Percentage of Head VS Tails for flipping the coin " + numberOfFlips + " number of times is as follows: ");
            Console.WriteLine("Head Probability: " + (head / numberOfFlips));
            Console.WriteLine("Tail Probability: " + (tail / numberOfFlips));
        }
    }
}
