using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Arrays");
        //Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.

        String[] cars = new String[3]; //declaration of array with size 3

        //String[] cars = {"BMW", "Volvo", "Ford"}; - inirialization of array with values

        cars[0] = "Opel";
        cars[1] = "BMW";
        cars[2] = "Volvo";

        //for loop to iterate through the array and print the values
        for (int i=0; i<cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }

        //foreach loop to iterate through the array and print the values
        foreach (String car in cars)
        {
            Console.WriteLine(car);
        }
    }
}