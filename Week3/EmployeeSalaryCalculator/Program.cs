using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculator
{
    class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Designation { get; set; }

        public Employee(int empId,string name,string designation,double salary)
        {
            EmpId = empId;
            Name = name;
            Designation = designation;
            Salary = salary;
        }

        public virtual double calculateBonus()
        {
            return 50000;
        }
    }

    class Developer:Employee
    {
        public Developer(int empId, string name, string designation, double salary) :base(empId,name,designation,salary)
        {
            
        }

        public override double calculateBonus()
        {
            double bonus=base.calculateBonus();
            if (0.2 * Salary > bonus){
                return 0.2 * Salary;
            }
            return bonus;
        }
    }

    class Manager : Employee
    {
        public Manager(int empId, string name, string designation, double salary) : base(empId, name, designation, salary)
        {

        }

        public override double calculateBonus()
        {
            double bonus = base.calculateBonus();
            if (0.25 * Salary > bonus)
            {
                return 0.25 * Salary;
            }
            return bonus;
        }
    }

    class Admin : Employee
    {
        public Admin(int empId, string name, string designation, double salary) : base(empId, name, designation, salary)
        {

        }

       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter employee Id:");
                int empId = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter employee Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Designation:");
                string designation = Console.ReadLine();

                Console.WriteLine("Enter Salary:");
                double salary = double.Parse(Console.ReadLine());
                if (designation == "Developer")
                {
                    Employee developer = new Developer(empId, name, designation, salary);
                    Console.WriteLine("Bonus calculated for Developer:" + developer.calculateBonus());
                }
                else if (designation == "Manager")
                {
                    Employee manager = new Manager(empId, name, designation, salary);
                    Console.WriteLine("Bonus calculated for Manager:" + manager.calculateBonus());
                }
                else if (designation == "Admin")
                {
                    Employee admin = new Admin(empId, name, designation, salary);
                    Console.WriteLine("Bonus calculated for Admin:" + admin.calculateBonus());
                }

                Console.WriteLine("Do you want to continue?(yes/no)");
                string input= Console.ReadLine();
                if (input == "no") break;
            }

        }
    }
}
