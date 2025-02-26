using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityBill
{
    internal class Program
    {

        static int calculateBill(int unit)
        {
            int charge = 0;
            if (unit < 0)
            {
                return -1;
            }
            if (unit >= 0 && unit <= 100)
            {
                charge = 2;
            }
            else if (unit > 100 && unit <= 200)
            {
                charge = 4;
            }
            else if (unit > 201 && unit <= 300)
            {
                charge = 6;
            }
            else
            {
                charge = 12;
            }
            return unit*charge;
        }

        static void Main(string[] args)
        {
            int result = -1;
            do
            {
                Console.Write("Enter units of Consuptions:");
                int unit = Convert.ToInt32(Console.ReadLine());
                result = calculateBill(unit);
                if (result == -1)
                {
                    Console.WriteLine("Invalid Input Try Again!!");
                }
            } while (result == -1);
            Console.WriteLine($"Your electricity bill is:{result} Rs.");




        }
    }
}
