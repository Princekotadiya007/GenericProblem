using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblems
{
    public class FindsMaxNumber
    {
        public int IntNumber(int firstNum, int secondNum, int thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
            {
                return firstNum;    
            }
            if (secondNum.CompareTo(thirdNum) > 0 && secondNum.CompareTo(firstNum) > 0)
            {
                return secondNum;
            }
            if (thirdNum.CompareTo(firstNum) > 0 && thirdNum.CompareTo(secondNum) > 0)
            {
                return thirdNum;
            }
            return firstNum;
        }
        public double FloatNumber(double firstNum, double secondNum, double thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
            {
                return firstNum;
            }
            if (secondNum.CompareTo(thirdNum) > 0 && secondNum.CompareTo(firstNum) > 0)
            {
                return secondNum;
            }
            if (thirdNum.CompareTo(firstNum) > 0 && thirdNum.CompareTo(secondNum) > 0)
            {
                return thirdNum;
            }
            return firstNum;
        }
        public string String(string firstNum, string secondNum, string thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
            {
                return firstNum;
            }
            if (secondNum.CompareTo(thirdNum) > 0 && secondNum.CompareTo(firstNum) > 0)
            {
                return secondNum;
            }
            if (thirdNum.CompareTo(firstNum) > 0 && thirdNum.CompareTo(secondNum) > 0)
            {
                return thirdNum;
            }
            return firstNum;
        }
        public static T GenericMethod<T>(T firstValue, T secondValue, T thirdValue) where T : IComparable
        {
            if (firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                return thirdValue;
            }
            //return value if all the numbers are equal
            return firstValue;
        }

        //Refactor to create generic class to take in 3 variables of generic type
        public class MaximumGenericClass<T> where T : IComparable
        {
            //generic variables
            public T firstValue, secondValue, thirdValue;
            public MaximumGenericClass(T firstValue, T secondValue, T thirdValue)
            {
                this.firstValue = firstValue;
                this.secondValue = secondValue;
                this.thirdValue = thirdValue;
            }

            //Refactor all 3 method in to one generic method and finding maximum value
            public static int GenericClass(int firstValue, int secondValue, int thirdValue)
            {
                if (firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) >= 0)
                {
                    return firstValue;
                }
                if (secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) >= 0)
                {
                    return secondValue;
                }
                if (thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) >= 0)
                {
                    return thirdValue;
                }
                return firstValue;
            }
        }
    }
}

