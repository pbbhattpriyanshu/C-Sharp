using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("String Methods");
        String fullName = "Piyush bhatt";
        String number = "123-456-7890";


        fullName = fullName.ToUpper();
        fullName = fullName.ToLower();
        number = number.Replace("-", "/");
        String username = fullName.Insert(0, "Mr.");
        String firstName = fullName.Substring(0, 6);
        String lastName = fullName.Substring(6);

        Console.WriteLine(fullName);
        Console.WriteLine(number);
        Console.WriteLine(username);
        Console.WriteLine(fullName.Length);
        Console.WriteLine(firstName);
        Console.WriteLine(lastName);

        //String interpolation - allow you to insert variables into a string without using concatenation

        String message = $"Hello {firstName}{lastName}, your phone number is {number}";
        Console.WriteLine(message);

        Console.ReadKey();
    }
}