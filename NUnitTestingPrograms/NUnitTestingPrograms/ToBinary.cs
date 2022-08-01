using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestingPrograms
{
    internal class ToBinary
    {
        public ToBinary()
        {
            Console.Write("enter the number for its binary form: ");
            Console.ReadLine() ;
            Console.WriteLine(Binary('n'));
            
        }
        public static string Binary(int n)
        {

            string st = "";
            while (n > 0)
            {
                st = n % 2 + st;
                n /= 2;
            }
            return st;
        }
    }
}
