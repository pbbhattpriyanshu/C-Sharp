using System;

//Polymorphism - method overloading (Compile time)

public class Calculator
{
    //method overloading (Compile time)
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}

public class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal Sound");
    }
}

public class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Meow");
    }
}