using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Objects");
            //Objects are instances of classes. They can have properties and methods that define their behavior.
            Human human1 = new Human();
            Human human2 = new Human();

            human1.firstName = "John";
            human1.age = 40;

            human2.firstName = "Jane";
            human2.age = 30;

            human1.Introduce();
            human1.Eat();
            human1.Sleep();

            human2.Introduce();
            human2.Eat();
            human2.Sleep();
        }
    }

    //Class
    class Human
    {
        public String firstName;
        public int age;

        //Method
        public void Introduce()
        {
            Console.WriteLine("Hello, my name is " + firstName + " and I am " + age + " years old.");
        }

        public void Eat()
        {
            Console.WriteLine(firstName + " is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine(firstName + " is sleeping.");
        }
    }
}