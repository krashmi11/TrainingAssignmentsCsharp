using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PropagationOfException1 propagationOfException1 = new PropagationOfException1();
                propagationOfException1.method1();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception finally handled at class {nameof(Program)}.{nameof(Main)}->{ex.Message}");

            }
            Console.WriteLine();

            UserRegistration userRegistration = new UserRegistration();
            try
            {
                userRegistration.RegisterUser(23);
                userRegistration.RegisterUser(15);
            }
            catch (Exception ex)
            {
                Console.WriteLine("User defined exception:");
                Console.WriteLine($"Exception caught:{ex.Message.ToString()}");
            }
            Console.WriteLine();

            try
            {
                Console.WriteLine("PF calculated:"+userRegistration.PFCalculation(60000, 45));
                Console.WriteLine();

                Console.WriteLine("System Defined Exception");
                Console.WriteLine("PF calculated:"+userRegistration.PFCalculation(60000, null));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

        }
    }
}
