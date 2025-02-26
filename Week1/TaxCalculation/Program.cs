using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculation
{
 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Employee Name:");
            string name=Console.ReadLine();
            Console.Write("Enter Ctc:");
            double ctc = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("By using 'new' keyword");
            Employee emp = new Employee(name, ctc);
            emp.calculateSalary();
            emp.displayEmployeeInfo();

            Console.ReadLine();
            Console.WriteLine("By using Instance Variable");
            Employee emp1 = new Employee("Saurabh", 1350000);
            emp1.calculateSalary();
            emp1.displayEmployeeInfo();

            Console.ReadLine();

            //Creating Reference to an existing object
            Console.WriteLine("Creating Reference to an existing object");
            Employee emp2 = emp1;
            emp2.calculateSalary();
            emp2.displayEmployeeInfo();

            Console.ReadLine();

            Console.WriteLine("By using array of objects:");
            Employee[] arrEmployee = new Employee[2];
            arrEmployee[0] = new Employee("John", 1900000);

            arrEmployee[1] = new Employee("Mary", 5000000);
            

            for(int i = 0; i < arrEmployee.Length; i++)
            {
                arrEmployee[i].calculateSalary();
                arrEmployee[i].displayEmployeeInfo();
                Console.WriteLine("-------------------------------");
            }

            Console.ReadLine();

            Console.WriteLine("By using Reflection:");
            //Reflection
            Type empType = typeof(Employee); //getting metadata of employee class
            ConstructorInfo constructorInfo = empType.GetConstructor(new[] { typeof(string), typeof(double)}); //finding matcing constructor in the employee class
            Employee emp3=(Employee)constructorInfo.Invoke(new Object[] { "Elina", 2300000});
            emp3.calculateSalary();
            emp3.displayEmployeeInfo();
            Console.ReadLine();


            //Partial class demonstration
            Console.WriteLine("Partial Class Demonstration:");
            Developer developer = new Developer(2);
            developer.calculateDeveloperTax();
            developer.Display();
            

        }
    }
}
