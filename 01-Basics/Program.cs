using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaration of a variable
        String firstName;
        // Initialization of a variable
        firstName = "John";
        String lastName = "Doe";

        int age = 22;
        bool alive = true;
        char symbol = '@';
        double height = 182.1;
        String username = symbol + firstName + lastName + age;

        Console.WriteLine("Your name is " + firstName);
        Console.WriteLine("Are you alive? " + alive);
        Console.WriteLine("Your age is " + age);
        Console.WriteLine("Your height is " + height + " cm");
        Console.WriteLine("Your Fav Symbol is " + symbol);
        Console.WriteLine("Your username is " + username);



        Console.ReadKey();
    }
}