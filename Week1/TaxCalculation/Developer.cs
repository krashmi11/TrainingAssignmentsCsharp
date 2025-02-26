using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculation
{
    partial class Developer
    {
        private double salary;
        public int Id { get; set; }
        public Developer(int id)
        {
            Id = id;
        }
        public double setSalary()
        {
            if (Id == 1) salary = 3500000D;
            if (Id == 2) salary = 2560000D;
            return salary;
        }

        

        public void setworkingTimeDev()
        {
            if (Id == 1)
                Console.WriteLine("Working 5 days from office");
            if (Id == 2) Console.WriteLine("Working for 3 days from office, 2 days remote");

        }

        public void setDesignation()
        {
            if (Id == 1) Console.WriteLine("IOS developer");
            if (Id == 2) Console.WriteLine("Android Developer");
        }


    }
}
