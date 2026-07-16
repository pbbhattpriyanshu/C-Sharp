using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Logical Operators");
        //Logical Operators - can used to combine multiple conditions is true or false
        // && - AND operator - returns true if both conditions are true, otherwise returns false.
        // || - OR operator - returns true if at least one condition is true, otherwise returns false.
        // ! - NOT operator - returns true if the condition is false, otherwise returns false.

        Console.WriteLine("What's the temperature outside? (C)");
        double temperature = Convert.ToDouble(Console.ReadLine());

        if (temperature >= 35)
        {
            Console.WriteLine("Don't go, It's To HOT outside");
        }
        else if (temperature >= 20 && temperature <= 35)
        {
            Console.WriteLine("Not bad, It's WARM outside");
        }
        else if (temperature >= 5 || temperature >= 19)
        {
            Console.WriteLine("Good, It's NICE outside");
        }
        else
        {
            Console.WriteLine("It's quite COLD outside");
        }

        Console.ReadKey();
    }
}