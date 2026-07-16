using System;

class Program
{
    static void Main(string[] args)
    {
        HandGame.Start();
        Console.WriteLine("Loops");
        //Loops - Repeating a block of code multiple times
        // For Loop - Repeats a block of code a specific number of times

        for(int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // While Loop - Repeats a block of code while a condition is true

        Console.WriteLine("Enter your name: ");
        String name = Console.ReadLine();

        while (name == "")
        {
            Console.WriteLine("Please Enter your name");
            name = Console.ReadLine();
        }

        Console.WriteLine("Hello " + name);

        //Nested Loops - A loop inside another loop
        Console.Write("How many rows do you want to print? ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("How many columns do you want to print? ");
        int columns = Convert.ToInt32(Console.ReadLine());

        Console.Write("What Symbol do you want to print? ");
        String symbol = Console.ReadLine();

        Console.WriteLine();

        for (int i = 0; i<rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }

        //Extra Challenge - Create a guessing game that uses a while loop to keep asking the user to guess a number until they get it right
        //GuessingGame.Start();

        //
        // Do While Loop - Repeats a block of code at least once and then continues while a condition is true

    }
}
