using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class InvalidAgeException:Exception
    {
        public InvalidAgeException():base("User Defined Exception:Age between 20 and 60.")
        {
            
        }
        public InvalidAgeException(string message) : base(message) { }

    }

    class UserRegistration
    {
        public void RegisterUser(int age)
        {
            if (age < 18 || age > 60)
            {
                throw new InvalidAgeException($"Invalid Age: {age}. Allowed range is 18-60.");
            }
            Console.WriteLine($"Age:{age} User registered successfully!");
        }

        public decimal? PFCalculation(decimal salary,int? multiplier)
        {
            if (multiplier == null) throw new ArgumentNullException("Multiplier Not found");
            return salary/multiplier;
        }
    }
    
}
