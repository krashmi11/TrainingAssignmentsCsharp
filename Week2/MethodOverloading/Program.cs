using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    
    class Calculator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public double Add(double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }

        public int Add(int[] numArray)
        {
            int sum = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                sum += numArray[i];
            }
            return sum;
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                Calculator calculator = new Calculator();
                Console.WriteLine("Sum of Integers:" + calculator.Add(21, 31));
                Console.WriteLine("Sum of doubles:" + calculator.Add(23.5, 2.5, 5.5));
                int[] arr = new int[] { 1, 2, 3, 5, 6 };
                Console.WriteLine("Sum of array of integers:" + calculator.Add(arr));
            }
        }
}
