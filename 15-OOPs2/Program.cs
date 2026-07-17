using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OOPs PART - 2");
            //Inheritance - Creating a child class that inherits from a parent class

            Car car = new Car();
            Jeep jeep = new Jeep();
            MotorBike bike = new MotorBike();

            Console.WriteLine(car.brand);
            Console.WriteLine(car.modelName);
            car.engine();
            Console.WriteLine(car.wheels);

            Console.WriteLine(bike.brand);

            //Abstract class - modifier that indicates missing components or incomplete implementation
            //Vehicle vehicle = new Vehicle();
        }
    }

    // Parent class - instance will not be create
    abstract class Vehicle
    {
        public string brand = "Ford";  // Vehicle attribute
        public void honk()             // Vehicle method
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    // Child class
    class Car : Vehicle
    {
        public string modelName = "Mustang";  // Car attribute
        public int wheels = 4; // Car attribute
        public void engine()
        {
            Console.WriteLine("Engine: V8");
            Console.WriteLine("Top Speed: 250 km/h");
        }
    }

    // Child class
    class Jeep: Vehicle
    {
        public string modelName = "Wrangler";  // Jeep attribute
        public int wheels = 6; // Jeep attribute
        public void engine()
        {
            Console.WriteLine("Engine: V6");
            Console.WriteLine("Top Speed: 180 km/h");
        }
    }

    // Child class
    class MotorBike : Vehicle
    {
        public string modelName = "Rog";
        public int wheels = 2;

        public void engine()
        {
            Console.WriteLine("Engine: V9 Turbo");
            Console.WriteLine("Top Speed: 220 Km/h");
        }
    }
}