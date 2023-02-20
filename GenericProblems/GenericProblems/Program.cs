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
            Console.WriteLine("\n1.Maximum Integer");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine(MaximumInteger.MaximumNumbers(25, 48, 401));
                    break;
            }
        }
    }
}
