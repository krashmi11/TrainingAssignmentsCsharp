using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDeviceControlSystem
{


    abstract class SmartDevice
    {
        public abstract void turnOn();
        public abstract void turnOn(int duration);
    }

    class SmartLight:SmartDevice
    {
        public override void turnOn()
        {
            Console.WriteLine("Smart Light turned on..");
        }
        public override void turnOn(int duration)
        {
            Console.WriteLine($"SmartLight turned on for {duration}  minutes");
        }
    }

    class SmartAc : SmartDevice
    {
        public override void turnOn()
        {
            Console.WriteLine("Smart Ac turned on..");
        }
        public override void turnOn(int duration)
        {
            Console.WriteLine($"Smart Ac turned on for {duration} minutes");
        }
    }

    class SmartTv : SmartDevice
    {
        public override void turnOn()
        {
            Console.WriteLine("SmartTv turned on..");
        }
        public override void turnOn(int duration)
        {
            Console.WriteLine($"SmartTv turned on for {duration} minutes");
        }
    }
    internal class Program
    {
        //    1. Smart Home Device Control System
        //Scenario: You are designing a smart home system where different devices(Lights, AC, TV) have different behaviors when turned on.
        //•	Create a base class SmartDevice with a method TurnOn().
        //•	Override TurnOn() in derived classes(SmartLight, SmartAC, SmartTV).
        //•	Implement a method TurnOn(int duration) in each class to keep the device on for a specific time.
        static void Main(string[] args)
        {
                SmartDevice device;
                device = new SmartLight();
                device.turnOn();
                device.turnOn(15);
                Console.WriteLine();

                device=new SmartAc();
                device.turnOn();
                device.turnOn(40);

                Console.WriteLine();

                device=new SmartTv();
                device.turnOn();
                device.turnOn(20);

                Console.WriteLine();

        }
    }
}
