using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum Problem Using Generics ");
            Console.WriteLine("choose the option");
            Console.WriteLine("\n1.Maximum Integer, \n2. MaximumFloats");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Maximum Integer Number");
                    Console.WriteLine(MaximumInteger.MaximumNumbers(25, 48, 401));
                    break;
                case 2:
                    Console.WriteLine("Maximum Floating Number");
                    Console.WriteLine(MaximumFloats.MaximumFloatsNumber(8.9, 10.2, 4.5));
                    break;
            }
        }
    }
}
