using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Address
    {
        private string street;
        private string city;
        private string state;
        private string postalCode;

        public Address(string street, string city, string state, string postalCode)
        {
            this.street = street;
            this.city = city;
            this.state = state;
            this.postalCode = postalCode;
        }

        public void displayAddress()
        {
            Console.WriteLine($"state:{state} city:{city} street:{street} postalCode:{postalCode}");
        }
    }
    class Student
    {
        private int rollNo;
        private string name;
        private Address address;
        public Student(int rollNo,string name,Address address)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.address = address;
        }
        public void displayInfo()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Roll No:" + rollNo);
            Console.WriteLine("Address:");
            address.displayAddress();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            do
            {
                Console.Write("Enter your name:");
                string name = Console.ReadLine();
                Console.Write("Enter Roll No.");
                int rollNo = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your full address:");
                Console.Write("Enter state:");
                string state = Console.ReadLine();
                Console.Write("Enter city:");
                string city = Console.ReadLine();
                Console.Write("Enter street Name:");
                string street = Console.ReadLine();
                Console.Write("Enter postalCode:");
                string zipCode = Console.ReadLine();

                Address address = new Address(street,city,state,zipCode);
                Student student=new Student(rollNo,name,address);
                student.displayInfo();
                Console.WriteLine("*****************************************************");
                Console.Write("Do you want to test for another input:(yes/no)");
                string input = Console.ReadLine();
                if (input == "no") break;
            } while (flag);
        }
    }
}
