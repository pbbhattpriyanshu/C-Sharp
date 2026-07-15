using System;

class Program
{
    static void Main(string[] args)
    {
        //Constant -> immutable values, do not change once initialize
        const double pi = 3.14;
        //pi = 34.4; can't be change
        Console.WriteLine(pi);

        //type casting -> converting the values into different data types
        double num = 99.2768; //.5 above = 100, .5 less = 99
        int reviseNum = Convert.ToInt32(num);

        int abc = 456;
        String str = abc.ToString();
        Console.WriteLine(reviseNum);
        Console.WriteLine(num.GetType()); //double
        Console.WriteLine(str); //string

        //Input from user
        Console.WriteLine("What is your name?");
        string? name = Console.ReadLine();

        Console.WriteLine("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hello, " + name);
        Console.WriteLine("age " + age);
                

        Console.ReadKey();
    }
}