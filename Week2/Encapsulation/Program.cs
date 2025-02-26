using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//hiding data+controlled access
//hides the sensitive from unauthorised access
//allow access to the data variables through public member functions
//hiding data inside class and allowing access to the data variables using public member functions
namespace Encapsulation
{
   class Account
    {
        private double balance; //sensitive data
        private string accountHolderName;
        private string accountNumber;

        public Account(string accountHolderName,string accountNumber,double balance)
        {
            this.accountHolderName = accountHolderName;
            this.accountNumber = accountNumber;
            this.balance = balance;
        }
        public void withdraw(double amount)
        {
            if (balance-amount >= 0)
            {
                balance -= amount;
                Console.WriteLine("Withdrawl Successful\n");
            }
            else
            {
                Console.WriteLine("Withdrawl not possible!!!\n");
            }
            

        }

        public void deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("Amount Deposited successfully.\n");
        }

        public void checkBalance()
        {
            Console.WriteLine($"Hello {accountHolderName}!!");
            Console.WriteLine("Amount Balance in account:" + balance+"\n");
        }
    }

    //Abstraction hiding complex details from the user and showing only essential details to the user
    abstract class ATM:Account
    {
        protected Account account;
        public ATM(string accountHolderName,string accountNummber, double balance) : base(accountHolderName,accountNummber,balance)
        {
            account=new Account(accountHolderName, accountNummber, balance);
        }
        public abstract void call1ForDeposit(double amount);
        public abstract void call2ForWithdraw(double amount);

        public abstract void call3ForAccountBalance();
        

    }

    class BankUser : ATM
    {
        public BankUser(string accountHolderName, string accountNummber, double balance) : base(accountHolderName, accountNummber, balance) { }
        
        public override void call1ForDeposit(double amount)
        {
            account.deposit(amount);
        }
        public override void call2ForWithdraw(double amount)
        {
            account.withdraw(amount);
        }

        public override void call3ForAccountBalance()
        {
            account.checkBalance();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            BankUser user1 = new BankUser("Rashmi", "BANKBOD12345", 20000);
            bool success = true;
            do
            {
                Console.WriteLine("Enter  1  for deposit:");
                Console.WriteLine("Enter 2 for withdraw:");
                Console.WriteLine("Enter 3 for account Balance:");
                Console.WriteLine("Enter 0 to exit...");
                int choice = int.Parse(Console.ReadLine());
                switch (choice) 
                { 
                
                    case 1:
                        Console.WriteLine("Enter amount to deposit:");
                        double amount = double.Parse(Console.ReadLine());
                        user1.deposit(amount);
                        break;
                    case 2:
                        Console.WriteLine("Enter amount to withdraw:");
                        amount = double.Parse(Console.ReadLine());
                        user1.withdraw(amount);
                        break;
                    case 3:
                        user1.checkBalance();
                        break;
                    case 0: success = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try Again!!\n");
                        break;
                }
            } while (success);
        }
    }
}
