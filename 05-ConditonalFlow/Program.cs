using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Conditional Flow");
        //if statement - basic form of conditional flow

        Console.WriteLine("Enter the age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 75)
        {
            Console.WriteLine("You are eligible for voting but as (senior citizen)");
        } 
        else if (age >= 75)
        {
            Console.WriteLine("You are eligible for voting");
        }
        else
        {
            Console.WriteLine("You are not eligible for voting");
        }

        Console.WriteLine("Enter your name: ");
        String name = Console.ReadLine();

        if (name == "") // = assignment operator, == comparison operator, != not equal operator
        {
            Console.WriteLine("You did not enter your name");
        } else
        {
            Console.WriteLine("Hello " + name);
        }

        //switch statement - another form of conditional flow its like many if else statements but more readable and easier to maintain

        Console.WriteLine("What day is today?");
        String day = Console.ReadLine();

        switch (day)
        {
            case "Monday":
                Console.WriteLine("It's bouring🫩!");
                break;
            case "Tuesday":
                Console.WriteLine("It's good🫡!");
                break;
            case "Wednesday":
                Console.WriteLine("It's not bad😑!");
                break;
            case "Thursday":
                Console.WriteLine("It's same same🤨!");
                break;
            case "Friday":
                Console.WriteLine("It's damn😙!");
                break;
            case "Saturday":
                Console.WriteLine("It's happy😁!");
                break;
            case "Sunday":
                Console.WriteLine("It's enjoy😎!");
                break;
            default:
                Console.WriteLine("Invalid day😵"); 
                break;
        }


        Console.ReadKey();
    }
}