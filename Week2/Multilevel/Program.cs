using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel
{
    class Vehicle
    {
        protected string licenceNo;
        protected string type;
        internal Vehicle(string licenceNo,string type)
        {
            this.licenceNo = licenceNo;
            this.type = type;
        }

        public virtual void startEngine()
        {
            Console.WriteLine("Engine Started.");
        }

        
    }
    class Car : Vehicle
    {
        protected string category;
        internal Car(string licenceNo, string category,string type) : base(licenceNo,type)
        {
            this.category = category;
        }
        public void Display()
        {
            Console.WriteLine("Vehicle type:" + type);
            Console.WriteLine($"Category of {type}:" + category);
            Console.WriteLine("Licence No:" + licenceNo);
        }
    }
    class ElectricCar : Car
    {
        internal ElectricCar(string licenceNo,string category,string type) : base(licenceNo, category,type) { }

        public void feature()
        {
            Console.WriteLine("Runs on Battery..");
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ElectricCar car1 = new ElectricCar("MH40BX5206","Electric", "Car");
            car1.Display(); // Car class
            car1.startEngine(); //Vehicle Class
            car1.feature(); //Electric Car
        }
    }
}
