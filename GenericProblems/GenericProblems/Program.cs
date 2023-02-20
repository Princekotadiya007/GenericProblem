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
            Console.WriteLine("\n1.Maximum Integer, \n2. Maximum Floats, \n3. Maximum String, \n4.Maximum Using Generic Method, \n5. Maximum Using Generic Class");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Maximum Integer Number");
                    Console.WriteLine(MaximumInteger.MaximumNumbers(25, 40, 40));
                    break;
                case 2:
                    Console.WriteLine("Maximum Floating Number");
                    Console.WriteLine(MaximumFloats.MaximumFloatsNumber(8.9, 10.2, 4.5));
                    break;
                case 3:
                    Console.WriteLine("Maximum String Number");
                    Console.WriteLine(MaximumString.FindString("prince", "vishal", "bhavin"));
                    break;
                case 4:
                    Console.WriteLine("Maximum using Generic Method");
                    Console.WriteLine("Maximum For Integer " + MaximumGenericMethod.GenericMethod(20, 85, 10));
                    Console.WriteLine("Maximum For Float " + MaximumGenericMethod.GenericMethod(2.0f, 8.5f, 1.0f));
                    Console.WriteLine("Maximum For String " + MaximumGenericMethod.GenericMethod("Karan", "Deep", "Milan"));
                    break;
                case 5:
                    Console.WriteLine("Maximum using Generic Class");
                    Console.WriteLine("Maximum For Integer " + MaximumGenericClass<int>.GenericClass(100, 115, 211));
                    Console.WriteLine("Maximum For Float " + MaximumGenericClass<float>.GenericClass(9.2f,6.3f,4.1f));
                    Console.WriteLine("Maximum For Float " + MaximumGenericClass<string>.GenericClass("Dinesh", "Mayank", "Risit"));
                    break;
                default:
                    Console.WriteLine("Invalied option");
                    break;
            }
        }
    }
}
