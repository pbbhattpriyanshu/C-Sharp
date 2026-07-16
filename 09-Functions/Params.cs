class Params
{
    public static void Start()
    {
        Console.WriteLine("Params keyword");
        //params keyword allows a method to accept a variable number of arguments

        double total = CheckOut(3.22, 4.55, 5.66, 6.77);

        Console.WriteLine("Total: " + total);
    }
    //Checkout function that accepts a variable number of arguments using params keyword
    static double CheckOut(params double[] prices)
    {
        double total = 0;
        foreach (double price in prices)
        {
            total += price;
        }
        return total;
    }
}