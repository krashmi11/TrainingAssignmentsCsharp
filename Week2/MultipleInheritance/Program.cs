using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    interface flyBehaviour
    {
        void fly();
    }

    interface swimBehaviour
    {
        void swim();
    }

    class canFly : flyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("Can Fly");
        }
    }

    class cannotFly : flyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("Cannot Fly.");

        }
    }

    class canSwim : swimBehaviour
    {
        public void swim()
        {
            Console.WriteLine("Can swim.");
        }
    }

    class cannotSwim : swimBehaviour
    {
        public void swim()
        {
            Console.WriteLine("Cannot swim.");
        }
    }

    class Duck
    {
        private string typeDuck;
        private flyBehaviour flybehave;
        private swimBehaviour swimbehave;
        internal Duck(string typeDuck,flyBehaviour flybehave, swimBehaviour swimbehave)
        {
            this.typeDuck = typeDuck;
            this.flybehave = flybehave;
            this.swimbehave = swimbehave;
        }

        public void DisplayDuckInfo()
        {
            Console.WriteLine($"Duck:{ typeDuck}");
            flybehave.fly();
            swimbehave.swim();
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck("Mallard Duck",new canFly(),new canSwim());
            duck.DisplayDuckInfo();

            duck=new Duck("Rubber Duck",new cannotFly(),new cannotSwim());
            duck.DisplayDuckInfo();

            duck = new Duck("Penguin Duck", new cannotFly(), new canSwim());
            duck.DisplayDuckInfo();
        }
    }
}
