using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Dog
    {
        protected int legs;
        protected string breed;
        public Dog(string breed,int legs=default)
        {
            Console.WriteLine("Dog Constructor is running");
            Console.WriteLine("legs:"+legs);
            this.breed = breed;
        }
        protected void makeSound()
        {
            Console.WriteLine("Dog Barks...");
        }
        public virtual void Display() {
            Console.WriteLine("Dog display");
        }
    }

    class GoldenRetriever : Dog
    {
        public GoldenRetriever(string breed, int legs) : base(breed,legs)
        {
            breed = "Golden Retriever";
            Console.WriteLine("Golden Retriever Constructor Running.");
        }
        public override void Display()
        {
            makeSound();
            Console.WriteLine(breed);
            Console.WriteLine(legs);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new GoldenRetriever("General",4);
            dog.Display();
            
        }
    }
}

