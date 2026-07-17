using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exception Handling in C#");
        //Exception Handling in C# is a mechanism that allows developers to handle runtime errors gracefully, preventing the application from crashing and providing a way to recover from unexpected situations. In C#, exceptions are represented by the System.Exception class and its derived classes.
        //try - try some code that may throw an exception
        //catch - catch the exception and handle it
        //finally - execute code that must run regardless of whether an exception occurred or not

        double x;
        double y;
        double result;

        try
        {
            Console.Write("Enter the first number: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = x / y;

            Console.WriteLine("result: " + result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Invalid input format.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }

        CondOperator.Start();
    }
}