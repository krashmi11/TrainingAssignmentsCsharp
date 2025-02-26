using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //1. Convert an Integer to a Double: Declare an int variable and assign a value. Convert it to a double using implicit casting.Print both values.
            int num = 978;
            Console.WriteLine("Integer:"+num);
            double doubleNum = num;
            Console.WriteLine("Implicit casting into Double:" + doubleNum);
            Console.ReadLine();

            //2.Convert a Character to an Integer(ASCII Value):
            //Declare a char variable(e.g., 'A').
            //Convert it to an int to get its ASCII value.
            //Print the result.
            char letter = 'A';
            Console.WriteLine($"Character '{letter}' and its Ascii value:{(int)letter}");
            letter = '&';
            Console.WriteLine($"Character '{letter}' and its Ascii value:{(int)letter}");
            Console.ReadLine();

            //3.Convert a Double to an Integer:
            //Declare a double variable with a decimal value.
            //Explicitly cast it to an int.
            //Print both values and observe the data loss.
            double num1 = 13.6565;
            Console.WriteLine("Double value:" + num1);
            Console.WriteLine("Explicitly casting it into an integer:" + (int)num1);
            Console.ReadLine();


            //4.Truncate a Float Value:
            //Declare a float variable with a decimal value.
            //Convert it to an int using explicit casting.
            //Print both values and note the truncated decimal.
            float floatNum = 12.4f;
            Console.WriteLine("Float value:"+floatNum);
            Console.WriteLine("Explicitly casting it into an integer:" + (int)floatNum);
            Console.ReadLine();

            //5.Convert a String to an Integer:
            //Declare a string variable with a numeric value(e.g., "100").
            //Convert it to an int using Convert.
            //Print the result.

            //7.Convert a String to an Integer using Parse():
            //Declare a string with a numeric value.
            //Convert it to an int using int.Parse().
            //Print the result.
            string str = "1230";
            Console.WriteLine($"Converting numeric string {str} to int using Convert:{Convert.ToInt32(str)}");
            Console.WriteLine($"Converting numeric string {str} to int using Parse:{int.Parse(str)}");
            Console.ReadLine();

            //6.Convert a Boolean to an Integer:
            //Declare a bool variable(true or false).
            //Convert it to an int using Convert.
            //Print the result(true → 1, false → 0).
            bool flag = true;
            Console.WriteLine($"Converting boolean {flag} into integer :{Convert.ToInt32(flag)}");
            flag = false;
            Console.WriteLine($"Converting boolean {flag} into integer :{Convert.ToInt32(flag)}");
            Console.ReadLine();

            //8.Handle Non-Numeric String using TryParse():
            //Declare a string variable with a non - numeric value(e.g., "ABC").
            //Try to convert it to an int using int.TryParse().
            //Print whether the conversion was successful.
            string str1 = "Rashmi";
            bool success = int.TryParse(str1, out int result);
            if (success)
            {
                Console.WriteLine("Conversion is successful.Converted value:" +result);
            }
            else
            {
                Console.WriteLine($"Conversion Failed for string {str1}");
                Console.WriteLine(result);
            }
            Console.ReadLine();

            //9.User Input Conversion:
            //Read a number from the console as a string.
            //Convert it to double using Convert.ToDouble().
            //Multiply the number by 10 and print the result.
            Console.Write("Enter a number:");
            doubleNum=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Multiply the number by 10 and print the result:" + doubleNum * 10);
            Console.ReadLine();




        }
    }
}
