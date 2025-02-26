using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation2
{
    internal class Employee
    {
        private int empId;
        private string name;
        private decimal salary;
        private string designation;

        private static List<Employee> employees=new List<Employee>();
        public Employee(int empId, string name, string designation, decimal salary)
        {
            this.name = name;
            this.empId = empId;
            this.salary = salary;
            this.designation = designation;
            employees.Add(this);
        }
        public string Name 
        {
            get { return name; }
            set { name = value; }
            
        }

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public void updateSalary(decimal newSalary)
        {
            try
            {
                this.salary = newSalary >= 0 ? newSalary : throw new Exception("Salary cannot be negative...");
                Console.WriteLine("Salary updated successfully!!!");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }
        public void showUpdatedDetails()
        {
            Console.WriteLine("EMPLOYEE INFORMATION:");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Employee Id:" + empId);
            Console.WriteLine("Employee Name:" + name);
            Console.WriteLine("Employee Designation:" + designation);
            Console.WriteLine("Employee Salary:" + salary);
            Console.WriteLine();
        }
        public void displayEmployeeDetails()
        {
            foreach (Employee emp in employees)
            {
                Console.WriteLine("Employee Id:" + emp.empId);
                Console.WriteLine("Employee Name:" + emp.name);
                Console.WriteLine("Employee Designation:" + emp.designation);
                Console.WriteLine("Employee Salary:" + emp.salary);
                Console.WriteLine("-------------------------------------------------------------------");
            }
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(101, "Rashmi", "Trainee Software Engineer", 8000);
            emp1.showUpdatedDetails();
            emp1.Designation = "Software Engineer";
            emp1.updateSalary(60000);
            emp1.showUpdatedDetails();

            emp1.updateSalary(-60000);
            emp1.showUpdatedDetails();

            Employee emp2 = new Employee(102, "Saurabh", "Software Engineer Intern", 25000);
            emp2.showUpdatedDetails();
            emp2.Designation = "Software Engineer";
            emp2.updateSalary(89000);
            emp2.showUpdatedDetails();
            Console.WriteLine("*****************************************************");
            Console.WriteLine("All Employee Details are displyed as below:");
            emp1.displayEmployeeDetails();
        }
    }
}
