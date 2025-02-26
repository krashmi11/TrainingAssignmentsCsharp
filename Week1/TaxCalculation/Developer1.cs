using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculation
{
    partial class Developer
    {

        public double TotalDeductedTax { get; set; }
        public double EmployeeSalary { get; set; }
        public double MarginalRelief { get; set; }
        public double TaxableIncome { get; set; }
        
        public void calculateDeveloperTax()
        {
            TaxRegimee taxRegimee = new TaxRegimee();
            TaxableIncome = taxRegimee.calculateTaxableIncome(setSalary());
            TotalDeductedTax = taxRegimee.calculateTax(TaxableIncome);
            MarginalRelief = taxRegimee.marginalRelief(TaxableIncome);
            EmployeeSalary = EmployeeSalaryHelper.calculateInhandSalary(setSalary(), (TotalDeductedTax-MarginalRelief));
        }


        public void Display()
        {
            setDesignation();
            setworkingTimeDev();
            Console.WriteLine("Developer Ctc:" + setSalary());
            Console.WriteLine("Total Deducted Tax:"+ (TotalDeductedTax-MarginalRelief));
            Console.WriteLine("Inhand Salary for developer:"+EmployeeSalary);
           

        }

    }
}
