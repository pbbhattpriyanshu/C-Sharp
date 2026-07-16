using System;

class Program
{
    static void Main(string[] args)
    {
        Params.Start(); // Calling the Start method from Params class
        Console.WriteLine("Functions/Methods");
        //Function - A block of code that performs a specific task and can be called multiple times in a program.
        greet(); // Calling the function
        greetPerson("John"); // Calling the function with parameter
        int result = addNumbers(5, 10); // Calling the function with parameters and return value
        Console.WriteLine("The sum is: " + result);

        // 1. Function Overloading - Defining multiple functions with the same name but different parameters
        // name + parameters = signature
        // function must have different signature to be overloaded
        int result2 = addNumbers(5, 10, 15); // Calling the overloaded function with different parameters
        Console.WriteLine("The sum is: " + result2);
    }

    //Function with no parameters and no return value
    static void greet()
    {
        Console.WriteLine("Good Morning!");
    }

    //Function with parameters and no return value
    static void greetPerson(string name)
    {
        Console.WriteLine("Good Morning, " + name + "!");
    }

    //Function with parameters and return value
    static int addNumbers(int a, int b)
    {
        return a + b;
    }

    //Function Overloading - Defining multiple functions with the same name but different parameters
    static int addNumbers(int a, int b, int c)
    {
        return a + b + c;
    }
}