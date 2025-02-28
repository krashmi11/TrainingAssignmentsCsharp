using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollSystem
{
    abstract class Employee
    {
        public string Name { get; set; }
        internal Employee(string name) { 
            Name=name;
        }
        public abstract void calculateSalary();
        public virtual void EmployeeDetails()
        {
            Console.WriteLine("Name:"+Name);
        }
    }
    class FullTimeEmployee:Employee
    {
        internal FullTimeEmployee(string name) : base(name) {
            Console.WriteLine("**********Full Time Employee*********");
        }
        public override void calculateSalary()
        {
            Console.WriteLine("Your Monthly Salary:85000");
        }
    }

    class ContractEmployee : Employee
    {
        public int Hours { get; set; }
        internal ContractEmployee(string name,int hours) : base(name) {
            Console.WriteLine("**********Contract Employee*********");
            Hours = hours;
        }
        public override void calculateSalary()
        {
            Console.WriteLine("Your Salary based on the number of hours worked:"+(Hours*300));
        }
        public override void EmployeeDetails()
        {
            base.EmployeeDetails();
            Console.WriteLine("No of hours worked:"+Hours);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee;
            while (true)
            {
                Console.WriteLine("1.Salary Calculation for Full Time Employee:");
                Console.WriteLine("2.Salary Calculation for Contract Employee:");
                Console.Write("Enter your choice:");
                int choice=int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter your Name:");
                        string name=Console.ReadLine();
                        employee=new FullTimeEmployee(name);
                        employee.EmployeeDetails();
                        employee.calculateSalary();
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine("Enter your Name:");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter number of hours yoou worked:");
                        int hours=int.Parse(Console.ReadLine());
                        employee = new ContractEmployee(name,hours);
                        employee.EmployeeDetails();
                        employee.calculateSalary();
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice.Try Again..");
                        break;

                }
                Console.WriteLine("Do you want to continue?(yes/no)");
                string input= Console.ReadLine();

                if (input == "no") break;
            }
        }
    }
}
