using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideFairCalculation
{
//    3. Ride Fare Calculation(Uber-like System)
//Scenario: A ride-booking app calculates fares differently based on ride type.
//•	Overload CalculateFare() to: 
//1.	Calculate fare for a regular ride
//2.	Calculate fare for a premium ride with a multiplier
//3.	Calculate fare for a shared ride with multiple passengers


    class RideFairCalculator
    {
        public double calculateFair(double distance,double ratePerKm)
        {
            return distance*ratePerKm;
        }

        public double calculateFair(double distance, double ratePerKm,double multiplier)
        {
            return distance*ratePerKm*multiplier;
        }

        public double calculateFair(double distance,double ratePerKm,int passengers,double discountPerPassenger)
        {
            double fare = distance * ratePerKm;
            double discount = (passengers - 1) * discountPerPassenger;
            return fare - discount;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            RideFairCalculator rideFairCalculator = new RideFairCalculator();
            while (true)
            {

                Console.WriteLine("Fare Ride Calculator:");
                Console.WriteLine("1.calculate fare for regular Ride:");
                Console.WriteLine("2.calculate fare for premium Ride:");
                Console.WriteLine("3.Calculate fare for Shared Ride:");
                Console.WriteLine("Enter your choice:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Distance travelled:");
                        double distanceTravelled = double.Parse(Console.ReadLine());
                        Console.Write("Enter rate per km:");
                        double ratePerKm = double.Parse(Console.ReadLine());

                        Console.WriteLine("Fare for you regular Ride:" + rideFairCalculator.calculateFair(distanceTravelled, ratePerKm));
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Write("Enter Distance travelled:");
                        distanceTravelled = double.Parse(Console.ReadLine());
                        Console.Write("Enter rate per km:");
                        ratePerKm = double.Parse(Console.ReadLine());
                        Console.Write("Enter multiplier:");
                        double multiplier = double.Parse(Console.ReadLine());
                        Console.WriteLine("Fare for you Premium Ride:" + rideFairCalculator.calculateFair(distanceTravelled, ratePerKm, multiplier));
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Write("Enter Distance travelled:");
                        distanceTravelled = double.Parse(Console.ReadLine());
                        Console.Write("Enter rate per km:");
                        ratePerKm = double.Parse(Console.ReadLine());
                        Console.Write("Enter number of passengers:");
                        int passengers = int.Parse(Console.ReadLine());
                        Console.Write("Enter discountRate per Passenger:");
                        double discounRate = double.Parse(Console.ReadLine());
                        Console.WriteLine("Fare for you shared Ride:" + rideFairCalculator.calculateFair(distanceTravelled, ratePerKm, passengers, discounRate));
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!!");
                        break;


                }
                Console.WriteLine("Do you want to continue?(yes/no)");
                string input = Console.ReadLine();
                if (input == "no") break;

            }
        }
    }
}
