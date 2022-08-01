using System;

namespace NUnitTestingPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To NUnit Testing Programs!");
            Console.WriteLine("Wending Machine program!");
            VendingMachine vm = new VendingMachine();
            vm.GiveChange(0);
        }
    }
}
