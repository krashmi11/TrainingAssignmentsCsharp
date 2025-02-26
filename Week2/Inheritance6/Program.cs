using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance6
{
    class Customer
    {
        private string name;
        private string address;
        private string phone;
        public Customer(string name, string address, string phone)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
        }
        public void display()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Phone:"+phone);
            Console.WriteLine("Address:"+address);
        }
    }
    class Account
    {
        private string accountNumber;
        private Customer customer;
        public Account(string accountNumber, Customer customer)
        {
            this.accountNumber = accountNumber;
            this.customer = customer;
        }
        public void displayAccountDetails()
        {
            customer.display();
            Console.WriteLine("Account No:"+accountNumber);
            Console.WriteLine();
        }
    }

    class Savings : Account
    {
        public Savings(string accountNumber, Customer customer) : base(accountNumber,customer)
        {
            Console.WriteLine("This is Saving Account.");
        }
    }

    class CurrentAccount : Account
    {
        public CurrentAccount(string accountNumber, Customer customer) : base(accountNumber, customer)
        {
            Console.WriteLine("This is Current Account.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Rashmi", "New Nanda Koradi", "7020709427");
            Account savings = new Savings("127934939", customer);
            savings.displayAccountDetails();

            customer = new Customer("Sabby", "London street", "677888272");
            Account current = new CurrentAccount("729222111", customer);
            current.displayAccountDetails();

        }
    }
}
