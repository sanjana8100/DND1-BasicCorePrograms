using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND1_BasicCorePrograms
{
    internal class VowelOrConsonant
    {
        public void vowelOrConsonant()
        {
            Console.WriteLine("Enter a character:");
            char ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("***************************************");
            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine(ch + " is a VOWEL");
                    break;
                default:
                    Console.WriteLine(ch + " is a CONSONANT");
                    break;
            }
        }
    }
}
