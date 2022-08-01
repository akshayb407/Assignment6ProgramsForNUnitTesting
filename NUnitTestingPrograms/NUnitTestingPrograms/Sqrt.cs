using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestingPrograms
{
    internal class Sqrt
    {
        public Sqrt()
        {
            Console.Write("enter the number for its SquareRoot:");
            
            Console.WriteLine("The Square root is : " + Sqroot('t'));
        }
        public double Sqroot(double t)
        {
            double c = t;
            double epsilon = 1e-15;
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2;
            }
            return t;
        }
    }
}
