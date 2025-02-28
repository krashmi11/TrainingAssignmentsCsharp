using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FactoryDesignPattern
{
    interface IVehicle
    {
        void startEngine();
        void stopEngine();
    }

    class Bike : IVehicle
    {
        public Bike()
        {
            Console.WriteLine("****** Vehicle:Bike ********");
        }
        public void startEngine()
        {
            Console.WriteLine("Engine Started for Bike🟢");
        }
        public void stopEngine()
        {
            Console.WriteLine("Engine stopped for Bike🛑");
        }
    }

    class Car : IVehicle
    {
        public Car()
        {
            Console.WriteLine("****** Vehicle:Car ********");
        }

        public void startEngine()
        {
            Console.WriteLine("Engine Started for Car🟢");
        }
        public void stopEngine()
        {
            Console.WriteLine("Engine stoped for Car🛑");
        }
    }

    class VehicleFactory
    {
        public static IVehicle GetVehicleType(string type)
        {
            if (type.ToLower().Equals("car"))
            {
                return new Car();
            }else if (type.ToLower().Equals("bike"))
            {
                return new Bike();
            }
            else
            {
                throw new Exception("Invalid Vehicle Type");
            }
        }
    }
    internal class Program
    {
//        2. Factory Pattern with Interfaces
//Scenario: You need to create objects dynamically at runtime based on user selection(e.g., creating a Car or Bike object).
//Question:
//Define a IVehicle interface with StartEngine() and StopEngine().
//Implement Car and Bike classes.
//Use a Factory pattern to return objects dynamically based on user input.
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter vehicle type:");
                string type = Console.ReadLine();
                try
                {
                    IVehicle vehicle = VehicleFactory.GetVehicleType(type);
                    vehicle.startEngine();
                    vehicle.stopEngine();
                    Console.WriteLine();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message.ToString());
                }
                Console.WriteLine("Do you want to continue?(yes/no)");
                if (Console.ReadLine().Equals("no")) break;
            } while (true);
        }
    }
}
