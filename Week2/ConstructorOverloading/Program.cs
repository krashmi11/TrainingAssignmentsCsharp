using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverLoading
{
    class Employee
    {
        private string name;
        private int age;
        public Employee()
        {
            Console.WriteLine("Default Constructor is called"); 
            this.name = "Unknown";
        }

        public Employee(string name)
        {
            Console.WriteLine("Constructor with only name is called");
            this.name = name;
        }
        public Employee(string name, int age)
        {
            Console.WriteLine("Constructor with only name and age is called");
            this.name = name;
            this.age = age;
        }
       
        public void Display()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("-----------------------------------------------------");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Display();

            emp = new Employee("Rashmi");
            emp.Display();


            emp = new Employee("Rashmi", 21);
            emp.Display();
        }
    }
}
