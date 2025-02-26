using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance3
{
    class Supplier
    {
        private string supplierName;
        private string contactDetails;
        public Supplier(string supplierName, string contactDetails)
        {
            this.supplierName = supplierName;
            this.contactDetails = contactDetails;
        }

        public void getSupplierInfo()
        {
            Console.WriteLine("Supplier Details");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Supplier Name:" + supplierName);
            Console.WriteLine("Contact Details:" + contactDetails);
        }
    }
    class Product
    {
        private string name;
        private decimal price;
        private string sku;
        private Supplier supplier;

        public Product(string name, decimal price, string sku, Supplier supplier)
        {
            this.name = name;
            this.price = price;
            this.sku = sku;
            this.supplier = supplier;
        }
        public void Display()
        {
            Console.WriteLine("Product Name:" + name);
            Console.WriteLine("Price:" + price);
            Console.WriteLine("Sku:" + sku);
            supplier.getSupplierInfo();
            Console.WriteLine();
        }

    }
    class Electronics : Product
    {
        public Electronics(string name, decimal price, string sku, Supplier supplier) : base(name,price,sku,supplier) 
        {
            Console.WriteLine("Welcome to Electronics Category.");
        }

        
    }
    class Clothing : Product
    {
        public Clothing(string name, decimal price, string sku, Supplier supplier) : base(name, price, sku, supplier)
        {
            Console.WriteLine("Welcome to Clothing Category.");
        }

    }
    class Groceries : Product
    {
        public Groceries(string name, decimal price, string sku, Supplier supplier) : base(name, price, sku, supplier)
        {
            Console.WriteLine("Welcome to Grocery Section.");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Supplier supplier1 = new Supplier("Boat","98459002");
            Electronics electronic = new Electronics("Boat Headphone", 1999, "BOAT-NEO-1999-P", supplier1);
            electronic.Display();

            supplier1 = new Supplier("AK Agency", "7394993");
            Clothing clothing=new Clothing("Anak kurta",999,"ANAK-45-P-09",supplier1);
            clothing.Display();

            supplier1 = new Supplier("InstaMart", "+91484884");
            Groceries groceries=new Groceries("Walnuts 250g",550,"NUT-INSTA-250-P",supplier1);
            groceries.Display();
        }
    }
}
