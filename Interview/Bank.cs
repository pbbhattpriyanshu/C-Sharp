using System;

//Encapsulation
public class Bank
{
	private double Balance;
	public double balance
	{
		get
		{
			return Balance;
		}
		set
		{
            if (value >= 0)
				Balance = value;
            
        }
	}

	public void CheckBal()
	{
		Console.WriteLine("Balance: " + Balance);
	}
}
