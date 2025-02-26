using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heirarchical
{
    class Animal
    {
        protected string animalName;
        internal Animal(string animalName)
        {
            this.animalName = animalName;
        }

        public virtual void speak()
        {
            Console.WriteLine($"{animalName} makes sound.");
        }
    }

    class Dog : Animal
    {
        internal Dog(string animalName) : base(animalName)
        {
        }

        public override void speak()
        {
            Console.WriteLine($"{animalName} barks.");
        }
    }

    class Cat : Animal
    {
        internal Cat(string animalName) : base(animalName)
        {
        }

        public override void speak()
        {
            Console.WriteLine($"{animalName} meows.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog("Dog");
            dog.speak();

            Console.WriteLine();

            Animal cat = new Cat("Cat");
            cat.speak();
        }
    }
}
