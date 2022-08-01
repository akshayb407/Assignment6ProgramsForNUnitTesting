using System;

namespace NUnitTestingPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To NUnit Testing Programs!");
            // Console.WriteLine("Wending Machine program!");
            //VendingMachine vm = new VendingMachine();
            //vm.GiveChange(0);

            //Console.WriteLine("Welcome To Day Of Week Program!");
            //DayOfWeek dayOfWeek = new DayOfWeek();

            //Console.WriteLine("Temperature Conversion Program");
            //TemperatureConversion tc = new TemperatureConversion();
            //tc.FahrenheitToC(0);
            //tc.CelsiusToF(0);

            Console.WriteLine("Monthly Payment Program!");
            MonthlyPayment mp = new MonthlyPayment();
            mp.Payment('p','y','r');
            
         
            
        }
    }
}
