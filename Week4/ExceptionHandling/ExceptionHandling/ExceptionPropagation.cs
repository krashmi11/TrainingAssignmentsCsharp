using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class PropagationOfException1
    {
        public void method1()
        {
            try
            {
                PropagationOfException2 propagationOfException2 = new PropagationOfException2();
                propagationOfException2.method2();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception caught at class {nameof(PropagationOfException1)}.{nameof(method1)}->{ex.Message}");
                throw;
            }

        }
    }

    class PropagationOfException2
    {
        public void method2()
        {
            try
            {
                PropagationOfException3 propagationOfException3 = new PropagationOfException3();
                propagationOfException3.method3();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception caught at class {nameof(PropagationOfException2)}.{nameof(method2)}->{ex.Message}");
                throw; //rethrows the same exception
            }
        }
    }
    class PropagationOfException3
    {
        public void method3()
        {
            throw new Exception($"Exception originated in class {nameof(PropagationOfException3)}.{nameof(method3)}");
        }

    }
}
