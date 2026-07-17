using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method overriding - provide a new version of a method inherited from a parent class.
            //                    inherited method must be : Abstract, virtual or already overriden
            //                    used with ToString(), polymorphism

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();

        }
    }

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes brrr");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes woof");
        }
    }

    class Cat: Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat goes meow");
        }
    }
}