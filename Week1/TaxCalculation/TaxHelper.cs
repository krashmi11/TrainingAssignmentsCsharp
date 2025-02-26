using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculation
{

    //abstract class
    public abstract class TaxCalculator
    {

        //abstract method
        public abstract double calculateTax(double salary);
    }

    //concrete class as it has its own functionalities and no abstract methods define. object can be instantiated
    public class TaxRegimee : TaxCalculator
    {
        double[] slabAmount = { 400000D, 800000D, 1200000D, 1600000D, 2000000D, 2400000D };
        double[] taxPercent = { 0.05, 0.1, 0.15, 0.2, 0.25, 0.3 };

        double rebateAmount = 60000D;

        public double calculateTaxableIncome(double ctc)
        {
            if(ctc>1275000)
                return ctc - 75000;
            return ctc;
            
        }
        public override double calculateTax(double taxableIncome)
        {
            double taxAmount = 0D;
            double taxSalary = taxableIncome;
            for (int i = slabAmount.Length-1; i >=0; i--)
            {
                if (taxSalary > slabAmount[i])
                {
                    taxAmount += (taxSalary-slabAmount[i]) * taxPercent[i];
                    taxSalary = slabAmount[i];
                }
               
            }

            return (taxAmount > rebateAmount) ? taxAmount : 0;
            

        }

        public double marginalRelief(double taxableIncome)
        {
            double taxAmount = calculateTax(taxableIncome);
            double excessIncome = taxableIncome - 1200000;
            if(taxableIncome>1200000 && taxAmount >excessIncome)
            {
                return taxAmount-excessIncome;
            }
            return 0;
        }
       
    }

    //static class
    public static class EmployeeSalaryHelper
    {
        public static double calculateInhandSalary(double ctc, double tax)
        {
            return ctc - tax;
        }
    }

    //sealed class
    //this class cannot be extended or overridden
    public sealed class Employee
    {
        public string Name { get; set; } //properties
        public double Ctc { get; set; }

        public double MarginalRelief { get; set; }
        public double TaxableIncome { get; set; }
        public double DeductedTax { get; set; }
        public double EmployeeSalary { get; set; }
        
        public Employee(string name, double ctc)


        {
            Name = name;
            Ctc = ctc;

        }

        public void calculateSalary()
        {
            TaxRegimee taxRegimee = new TaxRegimee();
            TaxableIncome = taxRegimee.calculateTaxableIncome(Ctc);
            DeductedTax = taxRegimee.calculateTax(TaxableIncome);
            MarginalRelief = taxRegimee.marginalRelief(TaxableIncome);
            double TotalDeductedTax = DeductedTax - MarginalRelief;
            EmployeeSalary = EmployeeSalaryHelper.calculateInhandSalary(Ctc, TotalDeductedTax);
        }

        public void displayEmployeeInfo()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Ctc:" + Ctc);
            Console.WriteLine("Taxable Income:" + TaxableIncome);
            Console.WriteLine("Tax Before Relief/Rebate:" + DeductedTax);
            Console.WriteLine("Marginal Relief:" + MarginalRelief);
            Console.WriteLine("Total Tax Deducted:" + (DeductedTax-MarginalRelief));
            Console.WriteLine("Inhand Salary:" + EmployeeSalary);

        }

    }

    
}
