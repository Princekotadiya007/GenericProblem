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
            Console.WriteLine("\n");

            Console.WriteLine("Maximum Integer Number");
            FindsMaxNumber findsMax = new FindsMaxNumber();
            Console.WriteLine(findsMax.IntNumber(25, 40, 40));
            Console.WriteLine("\n");

            Console.WriteLine("Maximum Float Number");
            Console.WriteLine(findsMax.FloatNumber(10.5f, 2.8f, 10.9f));
            Console.WriteLine("\n");

            Console.WriteLine("Maximum String Number");
            Console.WriteLine(findsMax.String("prince", "vishal", "bhavin"));

        }
    }
}

