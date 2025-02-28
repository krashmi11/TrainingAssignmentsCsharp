using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTDeviceCommunication
{
//    Scenario: You are building software for an IoT system where different devices(TemperatureSensor, MotionSensor, and LightController) communicate.
//Question:
//Define an IDevice interface with methods like Connect(), SendData(), and ReceiveData().
//Implement it for TemperatureSensor and MotionSensor.

    interface IDevice
    {
        void connect();
        void sendData();
        void receivedData();

    }

    class TemperatureSensor : IDevice
    {
        public string  ReceivedData { get; set; }
        public TemperatureSensor(string data) { 
            ReceivedData = data;
        }
        public void connect()
        {
            Console.WriteLine("Connected to Temperature Sensor.");
        }

        public void sendData()
        {
            Console.WriteLine("Your Data send successfully..");
        }

        public void receivedData()
        {
            Console.WriteLine("Data Received:"+ReceivedData);
        }
    }

    class MotionSensor : IDevice
    {
        public string ReceivedData { get; set; }
        public MotionSensor(string data)
        {
            ReceivedData = data;
        }
        public void connect()
        {
            Console.WriteLine("Connected to Motion Sensor.");
        }

        public void sendData()
        {
            Console.WriteLine("Your Data send successfully..");
        }

        public void receivedData()
        {
            Console.WriteLine("Data Received:" + ReceivedData);
        }
    }

    class LightController : IDevice
    {
        public string ReceivedData { get; set; }
        public LightController(string data)
        {
            ReceivedData = data;
        }
        public void connect()
        {
            Console.WriteLine("Connected to Light Controller.");
        }

        public void sendData()
        {
            Console.WriteLine("Your Data send successfully..");
        }

        public void receivedData()
        {
            Console.WriteLine("Data Received:" + ReceivedData);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IDevice device;
            Console.WriteLine("IOT DEVICE COMMUNICATION SYSTEM:");
            while (true)
            {
                Console.WriteLine("1.Temperature Sensor");
                Console.WriteLine("2.Motion Sensor");
                Console.WriteLine("3.Light Controller");
                Console.Write("Enter your choice:");
                int choice=int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("**********Temperature sensor********");
                        Console.Write("Enter data you want to send:");
                        string data= Console.ReadLine();
                        device = new TemperatureSensor(data);
                        device.connect();
                        device.sendData();
                        device.receivedData();
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine("**********Motion sensor********");
                        Console.Write("Enter data you want to send:");
                        data = Console.ReadLine();
                        device = new MotionSensor(data);
                        device.connect();
                        device.sendData();
                        device.receivedData();
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("**********Light Controller********");
                        Console.Write("Enter data you want to send:");
                        data = Console.ReadLine();
                        device = new LightController(data);
                        device.connect();
                        device.sendData();
                        device.receivedData();
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        Console.WriteLine();
                        break;
                }
                Console.WriteLine("Do you want to continue?(yes/no)");
                if (Console.ReadLine() == "no") break;
            }
        }
    }
}
