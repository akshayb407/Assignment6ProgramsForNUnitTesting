using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NUnitTestingPrograms
{
    internal class DayOfWeek
    {
        public DayOfWeek()
        {
            Console.WriteLine("enter the month date and year..");


             Console.WriteLine(GetWeekNumber(Convert.ToInt32('d'), Convert.ToInt32('m'),Convert.ToInt32('y')));
                                  
        }

        public String GetWeekNumber(int d, int m, int y)
        {

            int intTemp = Convert.ToInt32(Console.ReadLine());
            String[] array = {"Sunday","Monday","Tuesday","Wednesday","Thursday",
                    "Friday","Saturday" };
            int yf = y - (14 - m) / 12;
            int x = yf + yf / 4 - yf / 100 + yf / 400;
            int mf = m + 12 * ((14 - m) / 12) - 2;
            return array[((d + x + 31 * (mf / 12)) % 7)];
        }

    }
}
