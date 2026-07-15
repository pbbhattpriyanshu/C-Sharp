using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Math terminology");

        double x = 3.64;
        double y = 2.5;

        double a = Math.Pow(x, 2);
        double b = Math.Sqrt(x);
        double c = Math.Abs(x);
        double d = Math.Round(x);
        double e = Math.Ceiling(x);
        double f = Math.Floor(x);
        double g = Math.Max(x, y);
        double h = Math.Min(x, y);

        //Random values generate
        Random random = new Random();
        int num = random.Next(1, 7);
        double randomDouble = random.NextDouble();


        //WAP to calculate hypotenuse of a right triangle using Pythagorean theorem
        Console.WriteLine("Enter side A: ");
        double sideA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter side B: ");
        double sideB = Convert.ToDouble(Console.ReadLine());

        double sideC = Math.Sqrt((sideA * sideA) + (sideB * sideB));

        Console.WriteLine("The Hypotenuse: " + sideC);
        Console.ReadKey();
    }
}
