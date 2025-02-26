using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace BankInterestCalculation
{
    class Bank
    {
        public double calculateInterest(double principle, double rate, double time)
        {
            return (principle * rate * time) / 100;
        }

        public double calculateInterest(double principle, double rate, double time, double discounRate)
        {
            double discountedRate = rate - discounRate;
            return (principle * discountedRate * time) / 100;
        }

        public double calculateInterest(double principle, double rate, double time, double processingFee, double extraCharges)
        {
            double interest = (principle * rate * time) / 100;
            return interest + extraCharges + processingFee;

        }


    }
    internal class Program
    {

//        2. Bank Loan Interest Calculation
//Scenario: A bank offers different types of loans with varying interest rates.
//•	Overload CalculateInterest() to: 
//1.	Calculate interest for a personal loan
//2.	Calculate interest for a home loan with a special discount
//3.	Calculate interest for a custom loan with extra parameters

        
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bool success = true;
            while (success)
            {
                Console.WriteLine("1.Personal Loan:");
                Console.WriteLine("2.Home Loan Interest:");
                Console.WriteLine("3.Custom Loan Interest:");
                Console.WriteLine("Enter your choice:");
                int choice=int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter your Loan amount:");
                        double amount= double.Parse(Console.ReadLine());
                        Console.Write("Enter rate of interest:");
                        double rate=double.Parse(Console.ReadLine());
                        Console.Write("Enter time period:");
                        int time=int.Parse(Console.ReadLine());
                        Console.WriteLine("Personal Loan Interest:" + bank.calculateInterest(amount, rate, time));
                        break;

                    case 2:
                        Console.Write("Enter your Loan amount:");
                        amount = double.Parse(Console.ReadLine());
                        Console.Write("Enter rate of interest:");
                        rate = double.Parse(Console.ReadLine());
                        Console.Write("Enter time period:");
                        time = int.Parse(Console.ReadLine());
                        Console.Write("Enter Discount rate percent:");
                        double discountRate=double.Parse(Console.ReadLine());
                        Console.WriteLine("Home Loan Interest with special Discount:" + bank.calculateInterest(amount, rate, time, discountRate));
                        break;

                    case 3:
                        Console.Write("Enter your Loan amount:");
                        amount = double.Parse(Console.ReadLine());
                        Console.Write("Enter rate of interest:");
                        rate = double.Parse(Console.ReadLine());
                        Console.Write("Enter time period:");
                        time = int.Parse(Console.ReadLine());
                        Console.Write("Enter Processing fee:");
                        double processingFee = double.Parse(Console.ReadLine());
                        Console.Write("Enter Extra charges required :");
                        double extraCharges = double.Parse(Console.ReadLine());
                        Console.WriteLine("Custom Loan Interest:" + bank.calculateInterest(amount, rate, time, processingFee, extraCharges));
                        break;

                   
                    default:
                        Console.WriteLine("Invalid Input..");
                        break;

                }
                Console.WriteLine("Do you want to continue?(yes/no)");
                string input= Console.ReadLine();
                if(input=="no")success=false;
            }
            
            

        }
    }
}
