using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConvertor
{
    internal class Program
    {

        static float convertToFahrenheit(float celciumTemp)
        {
            float fahTemp = 1.8f * celciumTemp + 32;
            return fahTemp;
        }
        static void Main(string[] args)
        {
            bool flag = true;
            do
            {
                Console.Write("Enter temperature in Celcius:");
                float celciumTemp = float.Parse(Console.ReadLine());
                float fahrenheitTemp = convertToFahrenheit(celciumTemp);
                Console.WriteLine("Converted Temperature to Fahrenheit:" + fahrenheitTemp);
                Console.WriteLine("Do you want to continue?(y/n):");
                string input = Console.ReadLine();
                if (input == "n") flag = false;
            } while (flag);


        }
    }
}
