using System;

namespace firstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polymorphism");
            // polymorphism - Geek word means "many forms"
            //                object can be indentified by more than one type
            //                Ex. A dog is also: Canine, Animal, Organism

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Vechicle[] vehicles = { car, bicycle, boat };

            foreach (Vechicle vechicle in vehicles)
            {
                vechicle.Go();
            }

        }
    }

    class Vechicle
    {
        public virtual void Go()
        {
            
        }
    }

    class Car : Vechicle
    {
        public override void Go()
        {
            Console.WriteLine("Car is moving");
        }
    }

    class Bicycle : Vechicle
    {
        public override void Go()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Boat : Vechicle
    {
        public override void Go()
        {
            Console.WriteLine("Boat is moving");
        }
    }
}