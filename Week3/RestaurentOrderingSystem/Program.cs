using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurentOrderingSystem
{
    abstract class Order
    {
        public string Category { get; set; }
        public string Food { get; set; }
        internal Order(string category,string food)
        {
            Category = category;
            Food= food;
        }
        public void DisplayOrder()
        {
            Console.WriteLine($"Order placed in category {Category} for food item:{Food}.");
        }
        public abstract void placeOrder();
    }
    class DineInOrder : Order
    {
        internal DineInOrder(string category,string food) : base(category,food)
        {

        }
        public override void placeOrder()
        {
            Console.WriteLine("Order placed for Dine-In. Please proceed to the Dine-In area..");
        }
    }

    class TakeAwayOrder : Order
    {
        internal TakeAwayOrder(string category, string food) : base(category, food)
        {

        }
        public override void placeOrder()
        {
            Console.WriteLine("Order placed for Take-Away. Please wait while your order gets ready..");
        }
    }

    class OnlineOrder : Order
    {
        internal OnlineOrder(string category, string food) : base(category, food)
        {

        }
        public override void placeOrder()
        {
            Console.WriteLine("Your online order placed. You can track your order now..");
        }
    }
    internal class Program
    {
//        2. Restaurant Ordering System
//Scenario: A restaurant system processes different types of orders(Dine-in, Takeaway, Online).
//•	Create a base class Order with a method PlaceOrder().
//•	Override it in DineInOrder, TakeawayOrder, and OnlineOrder.
//•	Overload PlaceOrder() to handle different order types.
        static void Main(string[] args)
        {
            Order order;
            Console.WriteLine("Restaurent Ordering System");
            Console.WriteLine("**********************************");
            bool success = true;
            while (success)
            {
                Console.WriteLine("1. Enter 1 for DineInOrder:");
                Console.WriteLine("2. Enter 2 for TakeAwayOrder:");
                Console.WriteLine("3. Enter 3 for Online Order:");
                Console.Write("Please Enter youe choice:");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter food Category:");
                        string category= Console.ReadLine();
                        Console.Write("Enter dish name to order:");
                        string food= Console.ReadLine();
                        order=new DineInOrder(category, food);
                        order.DisplayOrder();
                        order.placeOrder();
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Write("Enter food Category:");
                        category = Console.ReadLine();
                        Console.Write("Enter dish name to order:");
                        food = Console.ReadLine();
                        order = new TakeAwayOrder(category, food);
                        order.DisplayOrder();
                        order.placeOrder();
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Write("Enter food Category:");
                        category = Console.ReadLine();
                        Console.Write("Enter dish name to order:");
                        food = Console.ReadLine();
                        order = new OnlineOrder(category, food);
                        order.DisplayOrder();
                        order.placeOrder();
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Invalid Order Category.Try Again!!");
                        Console.WriteLine();
                        break;


                }
                Console.WriteLine("Do you want to continue Ordering?(yes/no)");
                string input= Console.ReadLine();
                if (input.ToLower().Equals("no")) success = false;
            }

        }
    }
}
