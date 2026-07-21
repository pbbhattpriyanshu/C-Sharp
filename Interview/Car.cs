using System;

public class Car
{
	public string Brand { get; set; }
	public string Model { get; set; }
	public int Price { get; set; }
	public Car(string Brand, string Model, int Price)
	{
		this.Brand = Brand;
		this.Model = Model;
		this.Price = Price;
	}

	public void DisplayInfo()
	{
		Console.WriteLine($"Brand: {Brand}, Model: {Model}, Price: {Price}");
	}
}
