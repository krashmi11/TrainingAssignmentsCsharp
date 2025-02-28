using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingDiscountSystem
{
    abstract class Discount
    {
        public string DiscountTypeName { get; set; }
        public decimal Price { get; set; }
        protected Discount(string discountTypeName,decimal price)
        {
            DiscountTypeName= discountTypeName;
            Price = price;
        }
        public abstract void calculateDiscount(decimal price);
        public virtual void showDiscountDetails()
        {
            Console.WriteLine("Discount Type:"+DiscountTypeName);
            Console.WriteLine("Price:"+Price);
        }
    }

    class SeasonalDiscount : Discount
    {
        internal SeasonalDiscount(string discountTypeName, decimal price) : base(discountTypeName,price) {
            Console.WriteLine("*********Seasonal Discount Offered of 10% *********");
        }
        public override void calculateDiscount(decimal price)
        {
            decimal discount = (decimal)0.1 * price;
            Console.WriteLine("Discount offered:"+discount);
            Console.WriteLine("Discounted Price:"+(price-discount));
        }
    }

    class FestivalDiscount : Discount
    {
        internal FestivalDiscount(string discountTypeName, decimal price) : base(discountTypeName, price)
        {
            Console.WriteLine("*********Seasonal Discount Offered of 20% *********");
        }
        public override void calculateDiscount(decimal price)
        {
            decimal discount = (decimal)0.2 * price;
            Console.WriteLine("Discount offered:" + discount);
            Console.WriteLine("Discounted Price:" + (price - discount));
        }
    }

    class MembershipDiscount : Discount
    {
        internal MembershipDiscount(string discountTypeName, decimal price) : base(discountTypeName, price)
        {
            Console.WriteLine("*********Seasonal Discount Offered of 30% *********");
        }
        public override void calculateDiscount(decimal price)
        {
            decimal discount = (decimal)0.3 * price;
            Console.WriteLine("Discount offered:" + discount);
            Console.WriteLine("Discounted Price:" + (price - discount));
        }
    }

    internal class Program
    {
//        Scenario 2: Online Shopping Discount System

        //An e-commerce website offers different types of discounts:

        //Seasonal Discount

        //Festival Discount

        //Membership Discount


        //Each discount type has its own logic to calculate the discount on a given price.

        //Question:
        //Design an abstract class Discount with an abstract method CalculateDiscount(decimal price). Implement SeasonalDiscount, FestivalDiscount, and MembershipDiscount classes.
        static void Main(string[] args)
        {
            Discount discount;
            while (true)
            {
                Console.WriteLine("1.Seasonal Discount:");
                Console.WriteLine("2.Festival Discount:");
                Console.WriteLine("3.Membership Discount:");
                Console.Write("Enter your choice:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Season name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter price:");
                        decimal price = decimal.Parse(Console.ReadLine());
                        discount = new SeasonalDiscount(name,price);
                        discount.showDiscountDetails();
                        discount.calculateDiscount(price);
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine("Enter Festival name:");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter price:");
                        price = decimal.Parse(Console.ReadLine());
                        discount = new FestivalDiscount(name, price);
                        discount.showDiscountDetails();
                        discount.calculateDiscount(price);
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("Enter Membership type:");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter price:");
                        price = decimal.Parse(Console.ReadLine());
                        discount = new FestivalDiscount(name, price);
                        discount.showDiscountDetails();
                        discount.calculateDiscount(price);
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice.Try Again..");
                        break;

                }
                Console.WriteLine("Do you want to continue?(yes/no)");
                string input = Console.ReadLine();

                if (input == "no") break;
            }
        }
    }
}
