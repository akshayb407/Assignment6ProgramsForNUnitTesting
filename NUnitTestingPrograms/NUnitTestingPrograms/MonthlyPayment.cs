using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestingPrograms
{
    internal class MonthlyPayment
    {
        public MonthlyPayment()
        {
            Console.WriteLine("enter the Principal amount : ");
            int intp = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("enter no. of Years for PayOff : ");
            int inty = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("enter the interest rate in Percentage : ");
            int intr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Payment('p', 'y', 'r'));
        }
        public int Payment(int p, int y, int r)
        {
            double R = r / (12 * 100);
            int n = 12 * y;
            return (int)((p * R) / (1 - Math.Pow((1 + R), -n)));

        }
    }
}
