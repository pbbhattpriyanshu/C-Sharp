class CondOperator
{
    public static void Start()
    {
        Console.WriteLine("Conditional Operator");
        //Conditional Operator - used in conditional assignment if a condition is true/false.
        // Syntax - (condition) ? x : y

        double temperature = 4;
        string message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside";
        Console.WriteLine(message);
    }
}
