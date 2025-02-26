using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Vehicle
    {
        string licencePlate;
        int maxSpeed;
        public Vehicle(string licencePlate,int maxSpeed)
        {
            this.licencePlate = licencePlate;
            this.maxSpeed = maxSpeed;
        }
        public virtual void startEngine() { }
        public void display()
        {
            Console.WriteLine("Licence Plate Number:"+licencePlate);
            Console.WriteLine("Maximum speed:"+maxSpeed);
            startEngine();
        }
    }

    class Cars : Vehicle
    {
        
        public Cars(string licencePlate, int maxSpeed) : base(licencePlate, maxSpeed)
        {
            Console.WriteLine("Vehicle is Car..");
        }
        public override void startEngine()
        {
            Console.WriteLine("Engine started for Cars..");
        }
        
    }

    class Motorbikes : Vehicle
    {
       public Motorbikes(string licencePlate, int maxSpeed) : base(licencePlate, maxSpeed)
       {
            Console.WriteLine($"Vehicle are Motorbikes.");
       }
        public override void startEngine()
        {
            Console.WriteLine("Engine started for motorbikes..");
        }
    }

    class Bicycles : Vehicle
    {
        public Bicycles(string licencePlate, int maxSpeed) : base(licencePlate, maxSpeed)
        {
            Console.WriteLine("Vehicle is Bicycle.");
        }
        public override void startEngine()
        {
            Console.WriteLine("Bicycle do not have engine..");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cars car = new Cars("MH41BX4040", 85);
            car.display();
            Console.WriteLine();

            Vehicle bike = new Motorbikes("MH31AX1111", 75);
            bike.display();
            Console.WriteLine();

            Vehicle bicycle = new Bicycles("MH31PX5081", 40);
            bicycle.display();
;        }
    }
}
