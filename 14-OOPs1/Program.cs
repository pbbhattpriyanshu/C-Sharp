using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("OOPs PART - 1");
        //object instance of Pizza class
        Pizza pizza1 = new Pizza("Margherita", "Medium", 8.99);
        Pizza pizza2 = new Pizza("Pepperoni", "Large", 12.99);
        Pizza pizza3 = new Pizza("Vegetarian", "Small", 9.99);

        //object instance of Pizza class using constructor overloading
        Pizza pizza4 = new Pizza("BBQ Chicken", "Large", 14.99, "BBQ Sauce, Chicken, Onions", "Thin Crust");
        Pizza pizza5 = new Pizza("Hawaiian", "Medium", 11.99, "Ham, Pineapple", "Stuffed Crust");

        //Family meal - Pizza + Drink + Dessert - best way to use, from inheritance(Pizza part) + Drink + Dessert
        pizza1.FamilyMeal("Coke", "Chocolate Cake");

        //Display total number of pizza orders
        Console.WriteLine("Total Pizza Orders: " + Pizza.TotalOrder);
    }

    //Class Pizza
    class Pizza
    {
        //Properties
        public string Name { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public string Topping { get; set; } = string.Empty;
        public string Crust { get; set; } = string.Empty;

        //Static modifier - A static member belongs to the class itself rather than to any specific object of the class, and it can be accessed without creating an instance of the class.
        public static int TotalOrder;

        //Constructor - A special method that is automatically called when an object of a class is created
        //(Base Pizza)
        public Pizza(string name, string size, double price)
        {
            Name = name;
            Size = size;
            Price = price;
            TotalOrder++;

            Console.WriteLine($"Pizza Name: {Name}, Size: {Size}, Price: {Price}");
        }

        //Constructor Overloading - A class can have multiple constructors with different parameters, allowing for different ways to create objects of that class.
        //(Premium Pizza)
        public Pizza(string name, string size, double price, string topping, string crust)
        {
            Name = name;
            Size = size;
            Topping = topping;
            Crust = crust;
            Price = price;

            TotalOrder++;

            Console.WriteLine($"Pizza Name: {Name}, Size: {Size}, Topping: {topping}, Crust: {crust}, Price: {Price}");
        }

        //Family meal - Pizza + Drink + Dessert
        public void FamilyMeal(string drink, string dessert)
        {
            Console.WriteLine($"Family Meal: {Name} Pizza, Drink: {drink}, Dessert: {dessert}");
            TotalOrder++;
        }
    }
}