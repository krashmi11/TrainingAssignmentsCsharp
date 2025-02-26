using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heirarchical1
{
    abstract class Shape
    {
        public abstract double calculateArea();
        
    }

    class Circle : Shape
    {
        double radius;
        internal Circle(double radius)
        {
            Console.WriteLine("This is a circle");
            this.radius = radius;
        }
        public override double calculateArea()
        {
            return Math.PI * radius * radius;
        }

        public double calculateCircumference()
        {
            return 2*Math.PI*radius;
        }
    }

    class Rectangle : Shape
    {
        double length;
        double width;
        internal Rectangle(double length,double width)
        {
            Console.WriteLine("This is rectangle");
            this.length = length;
            this.width = width;
        }
        public override double calculateArea()
        {
            return length * width;
        }

        public double calculatePerimeter()
        {
            return 2 * (length + width);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle= new Circle(2.6);
            Console.WriteLine("Area of circle:"+circle.calculateArea());
            Console.WriteLine("Circumference of circle:"+circle.calculateCircumference());
            Console.WriteLine();

            Rectangle rectangle = new Rectangle(2, 4); ;
            Console.WriteLine("Area of Rectangle:" +rectangle.calculateArea());
            Console.WriteLine("Perimeter of Rectangle:" + rectangle.calculatePerimeter());
        }
    }
}
