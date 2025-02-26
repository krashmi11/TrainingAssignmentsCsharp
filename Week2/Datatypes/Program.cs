using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    class WeekFinder{
        private int input;
        public WeekFinder(int input)
        {
            this.input = input;
        }
        enum Week
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday

        }

        public string getDayOfWeek(int input)
        {
            if (input == (int)Week.Sunday) return "Sunday";
            if (input == (int)Week.Monday) return "Monday"; 
            if (input == (int)Week.Tuesday) return "Tuesday";
            if (input == (int)Week.Wednesday) return "Wednesday";
            if (input == (int)Week.Thursday) return "Thursday";
            if (input == (int)Week.Friday) return "Friday";
            if (input == (int)Week.Saturday) return "Saturday";

            return "Invalid Input";

        }


    }
    
    internal class Program
    {
        enum Week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        }
        static void Main(string[] args)
        {

            //Task 1 : Declare and initialize variables using the  data types & Print their values to the console
            //- int, float, double, decimal string, bool
            int intNum = 10;
            float floatNum = 3.278f;
            double doubleNum = 45.78955;
            decimal decimalNum = 0.08m;
            string name = "Rashmi";
            bool flag = true;
            Console.WriteLine("Integer:"+intNum);
            Console.WriteLine("Float:" + floatNum);
            Console.WriteLine("Double:" + doubleNum);
            Console.WriteLine("Decimal:" + decimalNum);
            Console.WriteLine("String:" + name);
            Console.WriteLine("Boolean:" + flag);
            Console.ReadLine();

            //Task 2 : Print minimum, maximum and default values for various datatypes.
            Console.WriteLine("Integer Data Type");
            Console.WriteLine($"Minimum and Maximum value for integer:{int.MinValue}   {int.MaxValue}");
            Console.WriteLine($"Minimum and Maximum value for unsigned integer:{uint.MinValue}   {uint.MaxValue}");
            Console.WriteLine($"Minimum and Maximum value for long integer:{long.MinValue}   {long.MaxValue}");
            Console.WriteLine($"Minimum and Maximum value for unsigned long integer:{ulong.MinValue}   {ulong.MaxValue}");
            Console.WriteLine($"Minimum and Maximum value for short integer:{short.MinValue}   {short.MaxValue}");
            Console.WriteLine($"Minimum and Maximum value for unsigned short integer:{ushort.MinValue}   {ushort.MaxValue}");
            Console.WriteLine($"Minimum and Maximum value for byte integer:{byte.MinValue}   {byte.MaxValue} \n");

            Console.WriteLine("Float Data Type");
            Console.WriteLine($"Minimum and Maximum value for Float:{float.MinValue}   {float.MaxValue}\n");

            Console.WriteLine("Double Data Type:");
            Console.WriteLine($"Minimum and Maximum value for Double:{double.MinValue}   {double.MaxValue}\n");

            Console.WriteLine("Decimal Data Type:");
            Console.WriteLine($"Minimum and Maximum value for Decimal:{decimal.MinValue}   {decimal.MaxValue}\n");

            Console.ReadLine() ;
            intNum = default;
            floatNum = default;
            doubleNum = default;
            decimalNum = default;
            name = default;
            flag = default;

            Console.WriteLine("Default Values:");
            Console.WriteLine("Default values for Integer:" + intNum);
            Console.WriteLine("Default values for Float:" + floatNum);
            Console.WriteLine("Default values for Double:" + doubleNum);
            Console.WriteLine("Default values for Decimal:" + decimalNum);
            Console.WriteLine("Default values for String:" + name);
            Console.WriteLine("Default values for Boolean:" + flag);
            Console.ReadLine();
            int?num= null;
            float? fnum = null;
            double? dnum = null;
            decimal? deciNum = null;
            bool? flag1 = null;
            Console.WriteLine("Nullable Data Type");
            Console.WriteLine("For Integer:"+num);
            Console.WriteLine("For Float:" + fnum);
            Console.WriteLine("For Decimal:" + deciNum);
            Console.WriteLine("For Boolean:" + flag1);
            Console.WriteLine("For Double:" + dnum);

            Console.ReadLine();
            Console.WriteLine("Enum Example:");
            Console.Write("Enter a valid input number to find Day of a week:");
            int input=int.Parse(Console.ReadLine());

            WeekFinder weekFinder = new WeekFinder(input);
            Console.WriteLine("Day:"+weekFinder.getDayOfWeek(input));

        }
    }
}
