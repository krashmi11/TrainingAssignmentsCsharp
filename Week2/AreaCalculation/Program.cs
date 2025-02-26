using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    class Shape
    {
        public double calculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double calculateArea(double length, double width)
        {
            return length * width;
        }
        public double calculateArea(double baseLength, double height, bool isTriangle)
        {
            return 0.5 * baseLength * height;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

                Shape shape = new Shape();
                double circleArea = shape.calculateArea(12.6);
                double rectangleArea = shape.calculateArea(10,12);
                double triangleArea = shape.calculateArea(2, 6, true);

                // Display results
                Console.WriteLine("Area of Circle: " + circleArea);
                Console.WriteLine("Area of Rectangle: " + rectangleArea);
                Console.WriteLine("Area of Triangle: " + triangleArea);
            }
    }
}
