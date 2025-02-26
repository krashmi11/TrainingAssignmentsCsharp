using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance4
{
    abstract class Employee
    {
        protected string name;
        protected string empId;
        protected decimal salary;

        public Employee(string name, string empId, decimal salary)
        {
            this.name = name;
            this.empId = empId;
            this.salary = salary;
        }
        public void Display()
        {
            Console.WriteLine("Employee Name:" + name);
            Console.WriteLine("Employee Id:"+empId);
            Console.WriteLine("Employee Salary:" + salary);
            work();
        }
        public abstract void work() ;
    }

    class Manager : Employee
    {
        private int teamSize;
        public Manager(string name, string empId, decimal salary,int teamSize) : base(name,empId,salary)
        {
            this.teamSize = teamSize;
        }

        public void manageTeam()
        {
            Console.WriteLine($"Manager is managing a team of {teamSize}.");
        }
        public override void work()
        {
            Console.WriteLine("Manager is conducting team meetings to get overview of projects.");
        }
    }

    class Engineer : Employee
    {
        string technology;
        public  Engineer(string name, string empId, decimal salary, string technology):base(name,empId,salary) 
        {
            this.technology = technology;
        }

        public override void work()
        {
            Console.WriteLine($"Engineer {name} is working on {technology}");
        }
    }

    class Intern : Employee
    {
        public Intern(string name, string empId, decimal salary) : base(name, empId, salary)
        {
        }
        public override void work()
        {
            Console.WriteLine("Intern is learning and working on new technology");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("John Joseph","EMP201",101500,8);
            manager.Display();
            manager.manageTeam();
            Console.WriteLine();

            Engineer engineer = new Engineer("Raj Vikramaditya","EMP101",97500,"CTRM");
            engineer.Display();
            Console.WriteLine();

            Intern intern = new Intern("Rashmi", "INT101", 25000);
            intern.Display();

        }
    }
}
