using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Multi-dimensional Array");
        // Multi-dimensional array - made up of rows and columns

        String[] ford = { "Mustang", "F-150", "Explorer" };
        String[] bmw = { "X5", "X3", "M3" };
        String[] chevy = { "Camaro", "Silverado", "Tahoe" };

        String[,] parking =
        {
            { "Mustang", "F-150", "Explorer" },
            { "X5", "X3", "M3" },
            { "Camaro", "Silverado", "Tahoe" }
        };

        // Change Explorer to Escape
        parking[0,2] = "Escape";

        // Display the array
        foreach(String car in parking)
        {
            Console.WriteLine(car);
        }
    }
}